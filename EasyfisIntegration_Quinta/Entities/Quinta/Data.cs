using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyfisIntegration_Quinta.Entities.Quinta
{
    public class RootObject
    {
        public CON CON { get; set; }
        public List<TRN> TRN { get; set; }
    }

    public class CON
    {
        public String DPI { get; set; }
        public String DCI { get; set; }
    }

    public class TRN
    {
        public Int32 FTN { get; set; }
        public Int32 PTN { get; set; }
        public String FID { get; set; }
        public String STS { get; set; }
        public String ADT { get; set; }
        public String DDT { get; set; }
        public String TDT { get; set; }
        public Int32 TCI { get; set; }
        public String TCC { get; set; }
        public String MEM { get; set; }
        public Int32 SAR { get; set; }
        public String SAI { get; set; }
        public String SAM { get; set; }
        public String ACI { get; set; }
        public String ACC { get; set; }
        public String RNO { get; set; }
        public String ACS { get; set; }
        public Boolean ADJ { get; set; }
        public String CUR { get; set; }
        public Decimal DSC { get; set; }
        public Decimal DSA { get; set; }
        public Decimal BAM { get; set; }
        public Decimal GAM { get; set; }
        public Decimal NBA { get; set; }
        public Decimal NAM { get; set; }
        public Int32 BNK { get; set; }
        public String BNM { get; set; }
        public String BOA { get; set; }
        public String CTI { get; set; }
        public String CNO { get; set; }
        public String VNO { get; set; }
        public String VDT { get; set; }
        public String CHQ { get; set; }
        public String RMK { get; set; }
        public String RMO { get; set; }
        public String CNT { get; set; }
        public Boolean WHT { get; set; }
        public String MRK { get; set; }
        public String SRC { get; set; }
        public List<JEN> JEN { get; set; }
    }

    public class JEN
    {
        public Int32 FTN { get; set; }
        public Int32 SAR { get; set; }
        public String FID { get; set; }
        public String SUF { get; set; }
        public String ACI { get; set; }
        public String ACS { get; set; }
        public String SAC { get; set; }
        public String ADC { get; set; }
        public String TDT { get; set; }
        public String GLC { get; set; }
        public Decimal DBT { get; set; }
        public Decimal CRD { get; set; }
        public Int32 BNK { get; set; }
        public String BNM { get; set; }
        public String BOA { get; set; }
        public String CTI { get; set; }
        public String CNO { get; set; }
        public String VNO { get; set; }
        public String VDT { get; set; }
        public String CHQ { get; set; }
    }

    public class TrnSalesInvoice
    {
        public String SIDate { get; set; }
        public String DocumentReference { get; set; }
        public String ManualSINumber { get; set; }
        public String CustomerCode { get; set; }
        public String Customer { get; set; }
        public String Remarks { get; set; }
        public String ItemCode { get; set; }
        public String Item { get; set; }
        public Decimal DiscountPercentage { get; set; }
        public Decimal DiscountAmount { get; set; }
        public Decimal VATAmount { get; set; }
        public Decimal Amount { get; set; }
        public String ORDate { get; set; }
        public String CheckNumber { get; set; }
        public String BankCode { get; set; }
        public String Bank { get; set; }
        public String Particulars { get; set; }
        public Boolean IsSales { get; set; }
    }
}
