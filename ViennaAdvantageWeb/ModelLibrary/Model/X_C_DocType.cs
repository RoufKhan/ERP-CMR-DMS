namespace VAdvantage.Model
{

/** Generated Model - DO NOT CHANGE */
using System;
using System.Text;
using VAdvantage.DataBase;
using VAdvantage.Common;
using VAdvantage.Classes;
using VAdvantage.Process;
using VAdvantage.Model;
using VAdvantage.Utility;
using System.Data;
/** Generated Model for C_DocType
 *  @author Jagmohan Bhatt (generated) 
 *  @version Vienna Framework 1.1.1 - $Id$ */
    public class X_C_DocType : PO
    {
        public X_C_DocType(Context ctx, int C_DocType_ID, Trx trxName)
            : base(ctx, C_DocType_ID, trxName)
        {
            /** if (C_DocType_ID == 0)
            {
            SetC_DocType_ID (0);
            SetDocBaseType (null);
            SetDocumentCopies (0);	// 1
            SetGL_Category_ID (0);
            SetHasCharges (false);
            SetIsCreateCounter (true);	// Y
            SetIsDefault (false);
            SetIsDefaultCounterDoc (false);
            SetIsDocNoControlled (true);	// Y
            SetIsInTransit (false);
            SetIsIndexed (false);
            SetIsPickQAConfirm (false);
            SetIsReturnTrx (false);	// N
            SetIsSOTrx (false);
            SetIsShipConfirm (false);
            SetIsSplitWhenDifference (false);	// N
            SetName (null);
            SetPrintName (null);
            }
             */
        }
        public X_C_DocType(Ctx ctx, int C_DocType_ID, Trx trxName)
            : base(ctx, C_DocType_ID, trxName)
        {
            /** if (C_DocType_ID == 0)
            {
            SetC_DocType_ID (0);
            SetDocBaseType (null);
            SetDocumentCopies (0);	// 1
            SetGL_Category_ID (0);
            SetHasCharges (false);
            SetIsCreateCounter (true);	// Y
            SetIsDefault (false);
            SetIsDefaultCounterDoc (false);
            SetIsDocNoControlled (true);	// Y
            SetIsInTransit (false);
            SetIsIndexed (false);
            SetIsPickQAConfirm (false);
            SetIsReturnTrx (false);	// N
            SetIsSOTrx (false);
            SetIsShipConfirm (false);
            SetIsSplitWhenDifference (false);	// N
            SetName (null);
            SetPrintName (null);
            }
             */
        }
        /** Load Constructor 
        @param ctx context
        @param rs result set 
        @param trxName transaction
        */
        public X_C_DocType(Context ctx, DataRow rs, Trx trxName)
            : base(ctx, rs, trxName)
        {
        }
        /** Load Constructor 
        @param ctx context
        @param rs result set 
        @param trxName transaction
        */
        public X_C_DocType(Ctx ctx, DataRow rs, Trx trxName)
            : base(ctx, rs, trxName)
        {
        }
        /** Load Constructor 
        @param ctx context
        @param rs result set 
        @param trxName transaction
        */
        public X_C_DocType(Ctx ctx, IDataReader dr, Trx trxName)
            : base(ctx, dr, trxName)
        {
        }
        /** Static Constructor 
         Set Table ID By Table Name
         added by ->Harwinder */
        static X_C_DocType()
        {
            Table_ID = Get_Table_ID(Table_Name);
            model = new KeyNamePair(Table_ID, Table_Name);
        }
        /** Serial Version No */
        //static long serialVersionUID 27562514371858L;
        /** Last Updated Timestamp 7/29/2010 1:07:35 PM */
        public static long updatedMS = 1280389055069L;
        /** AD_Table_ID=217 */
        public static int Table_ID;
        // =217;

        /** TableName=C_DocType */
        public static String Table_Name = "C_DocType";

        protected static KeyNamePair model;
        protected Decimal accessLevel = new Decimal(6);
        /** AccessLevel
        @return 6 - System - Client 
        */
        protected override int Get_AccessLevel()
        {
            return Convert.ToInt32(accessLevel.ToString());
        }
        /** Load Meta Data
        @param ctx context
        @return PO Info
        */
        protected override POInfo InitPO(Context ctx)
        {
            POInfo poi = POInfo.GetPOInfo(ctx, Table_ID);
            return poi;
        }
        /** Load Meta Data
        @param ctx context
        @return PO Info
        */
        protected override POInfo InitPO(Ctx ctx)
        {
            POInfo poi = POInfo.GetPOInfo(ctx, Table_ID);
            return poi;
        }
        /** Info
        @return info
        */
        public override String ToString()
        {
            StringBuilder sb = new StringBuilder("X_C_DocType[").Append(Get_ID()).Append("]");
            return sb.ToString();
        }
        /** Set Print Format.
        @param AD_PrintFormat_ID Data Print Format */
        public void SetAD_PrintFormat_ID(int AD_PrintFormat_ID)
        {
            if (AD_PrintFormat_ID <= 0) Set_Value("AD_PrintFormat_ID", null);
            else
                Set_Value("AD_PrintFormat_ID", AD_PrintFormat_ID);
        }
        /** Get Print Format.
        @return Data Print Format */
        public int GetAD_PrintFormat_ID()
        {
            Object ii = Get_Value("AD_PrintFormat_ID");
            if (ii == null) return 0;
            return Convert.ToInt32(ii);
        }

        /** C_DocTypeDifference_ID AD_Reference_ID=170 */
        public static int C_DOCTYPEDIFFERENCE_ID_AD_Reference_ID = 170;
        /** Set Difference Document.
        @param C_DocTypeDifference_ID Document type for generating in dispute Shipments */
        public void SetC_DocTypeDifference_ID(int C_DocTypeDifference_ID)
        {
            if (C_DocTypeDifference_ID <= 0) Set_Value("C_DocTypeDifference_ID", null);
            else
                Set_Value("C_DocTypeDifference_ID", C_DocTypeDifference_ID);
        }
        /** Get Difference Document.
        @return Document type for generating in dispute Shipments */
        public int GetC_DocTypeDifference_ID()
        {
            Object ii = Get_Value("C_DocTypeDifference_ID");
            if (ii == null) return 0;
            return Convert.ToInt32(ii);
        }

        /** C_DocTypeInvoice_ID AD_Reference_ID=170 */
        public static int C_DOCTYPEINVOICE_ID_AD_Reference_ID = 170;
        /** Set Document Type for Invoice.
        @param C_DocTypeInvoice_ID Document type used for invoices generated from this sales document */
        public void SetC_DocTypeInvoice_ID(int C_DocTypeInvoice_ID)
        {
            if (C_DocTypeInvoice_ID <= 0) Set_Value("C_DocTypeInvoice_ID", null);
            else
                Set_Value("C_DocTypeInvoice_ID", C_DocTypeInvoice_ID);
        }
        /** Get Document Type for Invoice.
        @return Document type used for invoices generated from this sales document */
        public int GetC_DocTypeInvoice_ID()
        {
            Object ii = Get_Value("C_DocTypeInvoice_ID");
            if (ii == null) return 0;
            return Convert.ToInt32(ii);
        }

        /** C_DocTypeProforma_ID AD_Reference_ID=170 */
        public static int C_DOCTYPEPROFORMA_ID_AD_Reference_ID = 170;
        /** Set Document Type for ProForma.
        @param C_DocTypeProforma_ID Document type used for pro forma invoices generated from this sales document */
        public void SetC_DocTypeProforma_ID(int C_DocTypeProforma_ID)
        {
            if (C_DocTypeProforma_ID <= 0) Set_Value("C_DocTypeProforma_ID", null);
            else
                Set_Value("C_DocTypeProforma_ID", C_DocTypeProforma_ID);
        }
        /** Get Document Type for ProForma.
        @return Document type used for pro forma invoices generated from this sales document */
        public int GetC_DocTypeProforma_ID()
        {
            Object ii = Get_Value("C_DocTypeProforma_ID");
            if (ii == null) return 0;
            return Convert.ToInt32(ii);
        }

        /** C_DocTypeShipment_ID AD_Reference_ID=170 */
        public static int C_DOCTYPESHIPMENT_ID_AD_Reference_ID = 170;
        /** Set Document Type for Shipment.
        @param C_DocTypeShipment_ID Document type used for shipments generated from this sales document */
        public void SetC_DocTypeShipment_ID(int C_DocTypeShipment_ID)
        {
            if (C_DocTypeShipment_ID <= 0) Set_Value("C_DocTypeShipment_ID", null);
            else
                Set_Value("C_DocTypeShipment_ID", C_DocTypeShipment_ID);
        }
        /** Get Document Type for Shipment.
        @return Document type used for shipments generated from this sales document */
        public int GetC_DocTypeShipment_ID()
        {
            Object ii = Get_Value("C_DocTypeShipment_ID");
            if (ii == null) return 0;
            return Convert.ToInt32(ii);
        }
        /** Set Document Type.
        @param C_DocType_ID Document type or rules */
        public void SetC_DocType_ID(int C_DocType_ID)
        {
            if (C_DocType_ID < 0) throw new ArgumentException("C_DocType_ID is mandatory.");
            Set_ValueNoCheck("C_DocType_ID", C_DocType_ID);
        }
        /** Get Document Type.
        @return Document type or rules */
        public int GetC_DocType_ID()
        {
            Object ii = Get_Value("C_DocType_ID");
            if (ii == null) return 0;
            return Convert.ToInt32(ii);
        }
        /** Set Description.
        @param Description Optional short description of the record */
        public void SetDescription(String Description)
        {
            if (Description != null && Description.Length > 255)
            {
                log.Warning("Length > 255 - truncated");
                Description = Description.Substring(0, 255);
            }
            Set_Value("Description", Description);
        }
        /** Get Description.
        @return Optional short description of the record */
        public String GetDescription()
        {
            return (String)Get_Value("Description");
        }

        /** DocBaseType AD_Reference_ID=432 */
        public static int DOCBASETYPE_AD_Reference_ID = 432;
        /** Set Document BaseType.
        @param DocBaseType Logical type of document */
        public void SetDocBaseType(String DocBaseType)
        {
            if (DocBaseType.Length > 3)
            {
                log.Warning("Length > 3 - truncated");
                DocBaseType = DocBaseType.Substring(0, 3);
            }
            Set_Value("DocBaseType", DocBaseType);
        }
        /** Get Document BaseType.
        @return Logical type of document */
        public String GetDocBaseType()
        {
            return (String)Get_Value("DocBaseType");
        }

        /** DocNoSequence_ID AD_Reference_ID=128 */
        public static int DOCNOSEQUENCE_ID_AD_Reference_ID = 128;
        /** Set Document Sequence.
        @param DocNoSequence_ID Document sequence determines the numbering of documents */
        public void SetDocNoSequence_ID(int DocNoSequence_ID)
        {
            if (DocNoSequence_ID <= 0) Set_Value("DocNoSequence_ID", null);
            else
                Set_Value("DocNoSequence_ID", DocNoSequence_ID);
        }
        /** Get Document Sequence.
        @return Document sequence determines the numbering of documents */
        public int GetDocNoSequence_ID()
        {
            Object ii = Get_Value("DocNoSequence_ID");
            if (ii == null) return 0;
            return Convert.ToInt32(ii);
        }

        /** DocSubTypeSO AD_Reference_ID=148 */
        public static int DOCSUBTYPESO_AD_Reference_ID = 148;
        /** Quotation = OB */
        public static String DOCSUBTYPESO_Quotation = "OB";
        /** Proposal = ON */
        public static String DOCSUBTYPESO_Proposal = "ON";
        /** Prepay Order = PR */
        public static String DOCSUBTYPESO_PrepayOrder = "PR";
        /** Standard Order = SO */
        public static String DOCSUBTYPESO_StandardOrder = "SO";
        /** On Credit Order = WI */
        public static String DOCSUBTYPESO_OnCreditOrder = "WI";
        /** Warehouse Order = WP */
        public static String DOCSUBTYPESO_WarehouseOrder = "WP";
        /** POS Order = WR */
        public static String DOCSUBTYPESO_POSOrder = "WR";
        /** Is test a valid value.
        @param test testvalue
        @returns true if valid **/
        public bool IsDocSubTypeSOValid(String test)
        {
            return test == null || test.Equals("OB") || test.Equals("ON") || test.Equals("PR") || test.Equals("SO") || test.Equals("WI") || test.Equals("WP") || test.Equals("WR");
        }
        /** Set SO Sub Type.
        @param DocSubTypeSO Sales Order Sub Type */
        public void SetDocSubTypeSO(String DocSubTypeSO)
        {
            if (!IsDocSubTypeSOValid(DocSubTypeSO))
                throw new ArgumentException("DocSubTypeSO Invalid value - " + DocSubTypeSO + " - Reference_ID=148 - OB - ON - PR - SO - WI - WP - WR");
            if (DocSubTypeSO != null && DocSubTypeSO.Length > 2)
            {
                log.Warning("Length > 2 - truncated");
                DocSubTypeSO = DocSubTypeSO.Substring(0, 2);
            }
            Set_Value("DocSubTypeSO", DocSubTypeSO);
        }
        /** Get SO Sub Type.
        @return Sales Order Sub Type */
        public String GetDocSubTypeSO()
        {
            return (String)Get_Value("DocSubTypeSO");
        }
        /** Set Document Copies.
        @param DocumentCopies Number of copies to be printed */
        public void SetDocumentCopies(int DocumentCopies)
        {
            Set_Value("DocumentCopies", DocumentCopies);
        }
        /** Get Document Copies.
        @return Number of copies to be printed */
        public int GetDocumentCopies()
        {
            Object ii = Get_Value("DocumentCopies");
            if (ii == null) return 0;
            return Convert.ToInt32(ii);
        }
        /** Set Document Note.
        @param DocumentNote Additional information for a Document */
        public void SetDocumentNote(String DocumentNote)
        {
            if (DocumentNote != null && DocumentNote.Length > 2000)
            {
                log.Warning("Length > 2000 - truncated");
                DocumentNote = DocumentNote.Substring(0, 2000);
            }
            Set_Value("DocumentNote", DocumentNote);
        }
        /** Get Document Note.
        @return Additional information for a Document */
        public String GetDocumentNote()
        {
            return (String)Get_Value("DocumentNote");
        }
        /** Set GL Category.
        @param GL_Category_ID General Ledger Category */
        public void SetGL_Category_ID(int GL_Category_ID)
        {
            if (GL_Category_ID < 1) throw new ArgumentException("GL_Category_ID is mandatory.");
            Set_Value("GL_Category_ID", GL_Category_ID);
        }
        /** Get GL Category.
        @return General Ledger Category */
        public int GetGL_Category_ID()
        {
            Object ii = Get_Value("GL_Category_ID");
            if (ii == null) return 0;
            return Convert.ToInt32(ii);
        }
        /** Set Charges.
        @param HasCharges Charges can be added to the document */
        public void SetHasCharges(Boolean HasCharges)
        {
            Set_Value("HasCharges", HasCharges);
        }
        /** Get Charges.
        @return Charges can be added to the document */
        public Boolean IsHasCharges()
        {
            Object oo = Get_Value("HasCharges");
            if (oo != null)
            {
                if (oo.GetType() == typeof(bool)) return Convert.ToBoolean(oo);
                return "Y".Equals(oo);
            }
            return false;
        }
        /** Set Pro forma Invoice.
        @param HasProforma Indicates if Pro Forma Invoices can be generated from this document */
        public void SetHasProforma(Boolean HasProforma)
        {
            Set_Value("HasProforma", HasProforma);
        }
        /** Get Pro forma Invoice.
        @return Indicates if Pro Forma Invoices can be generated from this document */
        public Boolean IsHasProforma()
        {
            Object oo = Get_Value("HasProforma");
            if (oo != null)
            {
                if (oo.GetType() == typeof(bool)) return Convert.ToBoolean(oo);
                return "Y".Equals(oo);
            }
            return false;
        }
        /** Set Create Counter Document.
        @param IsCreateCounter Create Counter Document */
        public void SetIsCreateCounter(Boolean IsCreateCounter)
        {
            Set_Value("IsCreateCounter", IsCreateCounter);
        }
        /** Get Create Counter Document.
        @return Create Counter Document */
        public Boolean IsCreateCounter()
        {
            Object oo = Get_Value("IsCreateCounter");
            if (oo != null)
            {
                if (oo.GetType() == typeof(bool)) return Convert.ToBoolean(oo);
                return "Y".Equals(oo);
            }
            return false;
        }
        /** Set Default.
        @param IsDefault Default value */
        public void SetIsDefault(Boolean IsDefault)
        {
            Set_Value("IsDefault", IsDefault);
        }
        /** Get Default.
        @return Default value */
        public Boolean IsDefault()
        {
            Object oo = Get_Value("IsDefault");
            if (oo != null)
            {
                if (oo.GetType() == typeof(bool)) return Convert.ToBoolean(oo);
                return "Y".Equals(oo);
            }
            return false;
        }
        /** Set Default Counter Document.
        @param IsDefaultCounterDoc The document type is the default counter document type */
        public void SetIsDefaultCounterDoc(Boolean IsDefaultCounterDoc)
        {
            Set_Value("IsDefaultCounterDoc", IsDefaultCounterDoc);
        }
        /** Get Default Counter Document.
        @return The document type is the default counter document type */
        public Boolean IsDefaultCounterDoc()
        {
            Object oo = Get_Value("IsDefaultCounterDoc");
            if (oo != null)
            {
                if (oo.GetType() == typeof(bool)) return Convert.ToBoolean(oo);
                return "Y".Equals(oo);
            }
            return false;
        }
        /** Set Document is Number Controlled.
        @param IsDocNoControlled The document has a document sequence */
        public void SetIsDocNoControlled(Boolean IsDocNoControlled)
        {
            Set_Value("IsDocNoControlled", IsDocNoControlled);
        }
        /** Get Document is Number Controlled.
        @return The document has a document sequence */
        public Boolean IsDocNoControlled()
        {
            Object oo = Get_Value("IsDocNoControlled");
            if (oo != null)
            {
                if (oo.GetType() == typeof(bool)) return Convert.ToBoolean(oo);
                return "Y".Equals(oo);
            }
            return false;
        }
        /** Set In Transit.
        @param IsInTransit Movement is in transit */
        public void SetIsInTransit(Boolean IsInTransit)
        {
            Set_Value("IsInTransit", IsInTransit);
        }
        /** Get In Transit.
        @return Movement is in transit */
        public Boolean IsInTransit()
        {
            Object oo = Get_Value("IsInTransit");
            if (oo != null)
            {
                if (oo.GetType() == typeof(bool)) return Convert.ToBoolean(oo);
                return "Y".Equals(oo);
            }
            return false;
        }
        /** Set Indexed.
        @param IsIndexed Index the document for the internal search engine */
        public void SetIsIndexed(Boolean IsIndexed)
        {
            Set_Value("IsIndexed", IsIndexed);
        }
        /** Get Indexed.
        @return Index the document for the internal search engine */
        public Boolean IsIndexed()
        {
            Object oo = Get_Value("IsIndexed");
            if (oo != null)
            {
                if (oo.GetType() == typeof(bool)) return Convert.ToBoolean(oo);
                return "Y".Equals(oo);
            }
            return false;
        }
        /** Set Pick/QA Confirmation.
        @param IsPickQAConfirm Require Pick or QA Confirmation before processing */
        public void SetIsPickQAConfirm(Boolean IsPickQAConfirm)
        {
            Set_Value("IsPickQAConfirm", IsPickQAConfirm);
        }
        /** Get Pick/QA Confirmation.
        @return Require Pick or QA Confirmation before processing */
        public Boolean IsPickQAConfirm()
        {
            Object oo = Get_Value("IsPickQAConfirm");
            if (oo != null)
            {
                if (oo.GetType() == typeof(bool)) return Convert.ToBoolean(oo);
                return "Y".Equals(oo);
            }
            return false;
        }
        /** Set Return Transaction.
        @param IsReturnTrx This is a return transaction */
        public void SetIsReturnTrx(Boolean IsReturnTrx)
        {
            Set_Value("IsReturnTrx", IsReturnTrx);
        }
        /** Get Return Transaction.
        @return This is a return transaction */
        public Boolean IsReturnTrx()
        {
            Object oo = Get_Value("IsReturnTrx");
            if (oo != null)
            {
                if (oo.GetType() == typeof(bool)) return Convert.ToBoolean(oo);
                return "Y".Equals(oo);
            }
            return false;
        }
        /** Set Sales Transaction.
        @param IsSOTrx This is a Sales Transaction */
        public void SetIsSOTrx(Boolean IsSOTrx)
        {
            Set_Value("IsSOTrx", IsSOTrx);
        }
        /** Get Sales Transaction.
        @return This is a Sales Transaction */
        public Boolean IsSOTrx()
        {
            Object oo = Get_Value("IsSOTrx");
            if (oo != null)
            {
                if (oo.GetType() == typeof(bool)) return Convert.ToBoolean(oo);
                return "Y".Equals(oo);
            }
            return false;
        }
        /** Set Ship/Receipt Confirmation.
        @param IsShipConfirm Require Ship or Receipt Confirmation before processing */
        public void SetIsShipConfirm(Boolean IsShipConfirm)
        {
            Set_Value("IsShipConfirm", IsShipConfirm);
        }
        /** Get Ship/Receipt Confirmation.
        @return Require Ship or Receipt Confirmation before processing */
        public Boolean IsShipConfirm()
        {
            Object oo = Get_Value("IsShipConfirm");
            if (oo != null)
            {
                if (oo.GetType() == typeof(bool)) return Convert.ToBoolean(oo);
                return "Y".Equals(oo);
            }
            return false;
        }
        /** Set Split when Difference.
        @param IsSplitWhenDifference Split document when there is a difference */
        public void SetIsSplitWhenDifference(Boolean IsSplitWhenDifference)
        {
            Set_Value("IsSplitWhenDifference", IsSplitWhenDifference);
        }
        /** Get Split when Difference.
        @return Split document when there is a difference */
        public Boolean IsSplitWhenDifference()
        {
            Object oo = Get_Value("IsSplitWhenDifference");
            if (oo != null)
            {
                if (oo.GetType() == typeof(bool)) return Convert.ToBoolean(oo);
                return "Y".Equals(oo);
            }
            return false;
        }
        /** Set Name.
        @param Name Alphanumeric identifier of the entity */
        public void SetName(String Name)
        {
            if (Name == null) throw new ArgumentException("Name is mandatory.");
            if (Name.Length > 60)
            {
                log.Warning("Length > 60 - truncated");
                Name = Name.Substring(0, 60);
            }
            Set_Value("Name", Name);
        }
        /** Get Name.
        @return Alphanumeric identifier of the entity */
        public String GetName()
        {
            return (String)Get_Value("Name");
        }
        /** Get Record ID/ColumnName
        @return ID/ColumnName pair */
        public KeyNamePair GetKeyNamePair()
        {
            return new KeyNamePair(Get_ID(), GetName());
        }
        /** Set Print Text.
        @param PrintName The label text to be printed on a document or correspondence. */
        public void SetPrintName(String PrintName)
        {
            if (PrintName == null) throw new ArgumentException("PrintName is mandatory.");
            if (PrintName.Length > 60)
            {
                log.Warning("Length > 60 - truncated");
                PrintName = PrintName.Substring(0, 60);
            }
            Set_Value("PrintName", PrintName);
        }
        /** Get Print Text.
        @return The label text to be printed on a document or correspondence. */
        public String GetPrintName()
        {
            return (String)Get_Value("PrintName");
        }

        /** R_MailText_ID AD_Reference_ID=274 */
        public static int R_MAILTEXT_ID_AD_Reference_ID = 274;
        /** Set Mail Template.
        @param R_MailText_ID Text templates for mailings */
        public void SetR_MailText_ID(int R_MailText_ID)
        {
            if (R_MailText_ID <= 0) Set_Value("R_MailText_ID", null);
            else
                Set_Value("R_MailText_ID", R_MailText_ID);
        }
        /** Get Mail Template.
        @return Text templates for mailings */
        public int GetR_MailText_ID()
        {
            Object ii = Get_Value("R_MailText_ID");
            if (ii == null) return 0;
            return Convert.ToInt32(ii);
        }
    }

}
