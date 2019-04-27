using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyfisIntegration_Quinta.Entities
{
    class Settings
    {
        public String CurrentToken { get; set; }
        public String APIURLSource { get; set; }
        public String HotelCode { get; set; }
        public String TimeTrigger { get; set; }
        public String ReturnPath { get; set; }
        public String APIURLHost { get; set; }
        public String DefaultVATOutput { get; set; }
        public String DefaultVATInput { get; set; }
        public String DefaultVTAX { get; set; }
        public String DefaultDiscount { get; set; }
        public String DefaultTerm { get; set; }
    }
}
