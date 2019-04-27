using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyfisIntegration_Quinta.Entities.Quinta
{
    public class CON
    {
        public string DPI { get; set; }
        public string DCI { get; set; }
    }

    public class RootObject
    {
        public CON CON { get; set; }
        public List<TRN> TRN { get; set; }
        public String DefaultTerm { get; set; }
        public String DefaultVatOutput { get; set; }
        public String DefaultVatInput { get; set; }
        public String DefaultWTax { get; set; }
        public String DefaultDiscount { get; set; }
    }

    public class TRN
    {
        public int FTN { get; set; }
        public int PTN { get; set; }
        public string FID { get; set; }
        public string STS { get; set; }
        public string ADT { get; set; }
        public string DDT { get; set; }
        public string TDT { get; set; }
        public int TCI { get; set; }
        public string TCC { get; set; }
        public string MEM { get; set; }
        public int SAR { get; set; }
        public string SAI { get; set; }
        public string SAM { get; set; }
        public string ACI { get; set; }
        public string ACC { get; set; }
        public string RNO { get; set; }
        public string ACS { get; set; }
        public string CUR { get; set; }
        public double DSC { get; set; }
        public double DSA { get; set; }
        public double BAM { get; set; }
        public double GAM { get; set; }
        public double NBA { get; set; }
        public double NAM { get; set; }
        public int BNK { get; set; }
        public string BNM { get; set; }
        public string BOA { get; set; }
        public string CTI { get; set; }
        public string CNO { get; set; }
        public string VNO { get; set; }
        public string VDT { get; set; }
        public string CHQ { get; set; }
        public string RMK { get; set; }
        public string RMO { get; set; }
        public string CNT { get; set; }
        public bool WHT { get; set; }
        public string MRK { get; set; }
        public string SRC { get; set; }
        public List<JEN> JEN { get; set; }
    }

    public class JEN
    {
        public int FTN { get; set; }
        public int SAR { get; set; }
        public string FID { get; set; }
        public string SUF { get; set; }
        public string ACI { get; set; }
        public string ACS { get; set; }
        public string SAC { get; set; }
        public string ADC { get; set; }
        public string TDT { get; set; }
        public string GLC { get; set; }
        public double DBT { get; set; }
        public double CRD { get; set; }
        public int BNK { get; set; }
        public string BNM { get; set; }
        public string BOA { get; set; }
        public string CTI { get; set; }
        public string CNO { get; set; }
        public string VNO { get; set; }
        public string VDT { get; set; }
        public string CHQ { get; set; }
    }
}
