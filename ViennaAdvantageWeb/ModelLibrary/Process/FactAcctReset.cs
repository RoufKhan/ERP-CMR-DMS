﻿/********************************************************
 * Project Name   : VAdvantage
 * Class Name     : FactAcctReset
 * Purpose        : Accounting Fact Reset
 * Class Used     : ProcessEngine.SvrProcess
 * Chronological    Development
 * Deepak           21-Nov-2009
  ******************************************************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using VAdvantage.Process;
using VAdvantage.Classes;
using VAdvantage.Model;
using VAdvantage.DataBase;
using VAdvantage.SqlExec;
using System.Data;
using System.Data.SqlClient;
using VAdvantage.Logging;
using VAdvantage.Utility;

using VAdvantage.ProcessEngine;namespace VAdvantage.Process
{
    public class FactAcctReset:ProcessEngine.SvrProcess
    {
    	/**	Client Parameter		*/
	private int		_AD_Client_ID = 0;
	/** Table Parameter			*/
	private int		_AD_Table_ID = 0;
	/**	Delete Parameter		*/
	private Boolean	_DeletePosting = false;
	
	private int		_countReset = 0;
	private int		_countDelete = 0;
	
	/// <summary>
	/// Prepare - e.g., get Parameters.
	/// </summary>
	protected override void Prepare()
	{
		ProcessInfoParameter[] para = GetParameter();
		for (int i = 0; i < para.Length; i++)
		{
			String name = para[i].GetParameterName();
			if (para[i].GetParameter() == null)
            {
				;
            }
			else if (name.Equals("AD_Client_ID"))
            {
				
                _AD_Client_ID = Utility.Util.GetValueOfInt(Utility.Util.GetValueOfDecimal(para[i].GetParameter()));
            }
			else if (name.Equals("AD_Table_ID"))
            {
				//_AD_Table_ID = ((BigDecimal)para[i].getParameter()).intValue();
                _AD_Table_ID = Utility.Util.GetValueOfInt(Utility.Util.GetValueOfDecimal(para[i].GetParameter()));
            }
			else if (name.Equals("DeletePosting"))
            {
				_DeletePosting = "Y".Equals(para[i].GetParameter());
            }
			else
            {
				log.Log(Level.SEVERE, "Unknown Parameter: " + name);
            }
		}
	}	//	prepare

	/// <summary>
	/// Perrform Process.
	/// </summary>
	/// <returns>(clear text)</returns>
	protected override String DoIt()
	{
		log.Info("AD_Client_ID=" + _AD_Client_ID 
			+ ", AD_Table_ID=" + _AD_Table_ID + ", DeletePosting=" + _DeletePosting);
		//	List of Tables with Accounting Consequences
		String sql = "SELECT AD_Table_ID, TableName "
			+ "FROM AD_Table t "
			+ "WHERE t.IsView='N'";
        if (_AD_Table_ID > 0)
        {
            sql += " AND t.AD_Table_ID=" + _AD_Table_ID;
        }
		sql += " AND EXISTS (SELECT * FROM AD_Column c "
				+ "WHERE t.AD_Table_ID=c.AD_Table_ID AND c.ColumnName='Posted' AND c.IsActive='Y')";
		IDataReader idr = null;
        try
        {
            idr = DataBase.DB.ExecuteReader(sql, null, Get_TrxName());
            while (idr.Read())
            {
                int AD_Table_ID = Utility.Util.GetValueOfInt(idr[0]);// rs.getInt(1);
                String TableName = Utility.Util.GetValueOfString(idr[1]);// rs.getString(2);
                if (_DeletePosting)
                {
                    Delete(TableName, AD_Table_ID);
                }
                else
                {
                    Reset(TableName);
                }
            }
            idr.Close();
        }
        catch (Exception e)
        {
            if (idr != null)
            {
                idr.Close();
            }
            log.Log(Level.SEVERE, sql, e);
        }
        
		//	Balances
        if (_DeletePosting)
        {
          





          //  FinBalance.updateBalanceClient(GetCtx(), _AD_Client_ID, true);		//	delete












        }
		//
		return "@Updated@ = " + _countReset + ", @Deleted@ = " + _countDelete;
	}	//	doIt
    /// <summary>
    /// Reset Accounting Table and update count
    /// </summary>
    /// <param name="TableName">table</param>
	private void Reset (String TableName)
	{
		String sql = "UPDATE " + TableName
			+ " SET Processing='N' WHERE AD_Client_ID=" + _AD_Client_ID
			+ " AND (Processing<>'N' OR Processing IS NULL)";
		    int unlocked = DataBase.DB.ExecuteQuery(sql,null, Get_TrxName());
		sql = "UPDATE " + TableName
			+ " SET Posted='N' WHERE AD_Client_ID=" + _AD_Client_ID
			+ " AND (Posted NOT IN ('Y','N') OR Posted IS NULL) AND Processed='Y'";
		    int invalid = DataBase.DB.ExecuteQuery(sql,null, Get_TrxName());
        if (unlocked + invalid != 0)
        {
            log.Fine(TableName + " - Unlocked=" + unlocked + " - Invalid=" + invalid);
        }
		_countReset += unlocked + invalid; 
	}	//	reset

	/// <summary>
	/// Delete Accounting Table where period status is open and update count.
	/// </summary>
	/// <param name="TableName">table name</param>
	/// <param name="AD_Table_ID">table</param>
	private void Delete (String TableName, int AD_Table_ID)
	{
		Reset(TableName);
		_countReset = 0;
		//
		String docBaseType = null;
        if (AD_Table_ID == MInvoice.Table_ID)
        {
            docBaseType = "IN ('" + MDocBaseType.DOCBASETYPE_APINVOICE
                + "','" + MDocBaseType.DOCBASETYPE_APCREDITMEMO
                + "','" + MDocBaseType.DOCBASETYPE_ARINVOICE
                + "','" + MDocBaseType.DOCBASETYPE_ARCREDITMEMO
                + "','" + MDocBaseType.DOCBASETYPE_ARPROFORMAINVOICE + "')";
        }  
        else if (AD_Table_ID == MInOut.Table_ID)
        {
            docBaseType = "IN ('" + MDocBaseType.DOCBASETYPE_MATERIALDELIVERY
                + "','" + MDocBaseType.DOCBASETYPE_MATERIALRECEIPT + "')";
        }
        else if (AD_Table_ID == MPayment.Table_ID)
        {
            docBaseType = "IN ('" + MDocBaseType.DOCBASETYPE_APPAYMENT
                + "','" + MDocBaseType.DOCBASETYPE_ARRECEIPT + "')";
        }
        else if (AD_Table_ID == MOrder.Table_ID)
        {
            docBaseType = "IN ('" + MDocBaseType.DOCBASETYPE_SALESORDER
                + "','" + MDocBaseType.DOCBASETYPE_PURCHASEORDER + "')";
        }
        else if (AD_Table_ID == MProjectIssue.Table_ID)
        {
            docBaseType = "= '" + MDocBaseType.DOCBASETYPE_PROJECTISSUE + "'";
        }
        else if (AD_Table_ID == MBankStatement.Table_ID)
        {
            docBaseType = "= '" + MDocBaseType.DOCBASETYPE_BANKSTATEMENT + "'";
        }
        else if (AD_Table_ID == MCash.Table_ID)
        {
            docBaseType = "= '" + MDocBaseType.DOCBASETYPE_CASHJOURNAL + "'";
        }
        else if (AD_Table_ID == MAllocationHdr.Table_ID)
        {
            docBaseType = "= '" + MDocBaseType.DOCBASETYPE_PAYMENTALLOCATION + "'"; 
        }




        //else if (AD_Table_ID == MJournal.Table_ID)
        //{
            //docBaseType = "= '" + MDocBaseType.DOCBASETYPE_GLJOURNAL + "'";

        //}
        //	else if (AD_Table_ID == M.Table_ID)
         // {
        //		docBaseType = "= '" + MDocBaseType.DOCBASETYPE_GLDocument + "'";
        //  }
        else if (AD_Table_ID == MMovement.Table_ID)
        {
            docBaseType = "= '" + MDocBaseType.DOCBASETYPE_MATERIALMOVEMENT + "'";
        }
        else if (AD_Table_ID == MRequisition.Table_ID)
        {
            docBaseType = "= '" + MDocBaseType.DOCBASETYPE_PURCHASEREQUISITION + "'";
        }
        else if (AD_Table_ID == MInventory.Table_ID)
        {
            docBaseType = "= '" + MDocBaseType.DOCBASETYPE_MATERIALPHYSICALINVENTORY + "'";
        }
        else if (AD_Table_ID == X_M_Production.Table_ID)
        {
            docBaseType = "= '" + MDocBaseType.DOCBASETYPE_MATERIALPRODUCTION + "'";
        }
        else if (AD_Table_ID == MMatchInv.Table_ID)
        {
            docBaseType = "= '" + MDocBaseType.DOCBASETYPE_MATCHINVOICE + "'";
        }
        else if (AD_Table_ID == MMatchPO.Table_ID)
        {
            docBaseType = "= '" + MDocBaseType.DOCBASETYPE_MATCHPO + "'";
        }
		//
		if (docBaseType == null)
		{
			String s = TableName + ": Unknown DocBaseType";
			log.Severe(s);
			AddLog(s);
			docBaseType = "";
			return;
		}
		else
			docBaseType = " AND pc.DocBaseType " + docBaseType;
		
		//	Doc
		String sql1 = "UPDATE " + TableName + " doc"
			+ " SET Posted='N', Processing='N' "
			+ "WHERE AD_Client_ID=" + _AD_Client_ID
			+ " AND (Posted<>'N' OR Posted IS NULL OR Processing<>'N' OR Processing IS NULL)"
			+ " AND EXISTS (SELECT * FROM C_PeriodControl pc"
				+ " INNER JOIN Fact_Acct fact ON (fact.C_Period_ID=pc.C_Period_ID) "
				+ "WHERE pc.PeriodStatus = 'O'" + docBaseType
				+ " AND fact.AD_Table_ID=" + AD_Table_ID
				+ " AND fact.Record_ID=doc." + TableName + "_ID)";
		 int reset = DataBase.DB.ExecuteQuery(sql1,null, Get_TrxName()); 
		//	Fact
		String sql2 = "DELETE FROM Fact_Acct fact "
			+ "WHERE AD_Client_ID=" + _AD_Client_ID
			+ " AND AD_Table_ID=" + AD_Table_ID
			+ " AND EXISTS (SELECT * FROM C_PeriodControl pc "
				+ "WHERE pc.PeriodStatus = 'O'" + docBaseType
				+ " AND fact.C_Period_ID=pc.C_Period_ID)";
		  int deleted = DataBase.DB.ExecuteQuery(sql2,null, Get_TrxName());
		//
		log.Info(TableName + "(" + AD_Table_ID + ") - Reset=" + reset + " - Deleted=" + deleted);
		String s1 = TableName + " - Reset=" + reset + " - Deleted=" + deleted;
		AddLog(s1);
        if (reset == 0)
        {
            log.Finest(sql1);
        }
        if (deleted == 0)
        {
            log.Finest(sql2);
        }
		//
		_countReset += reset;
		_countDelete += deleted;
	}	//	delete

}	//	FactAcctReset

}
