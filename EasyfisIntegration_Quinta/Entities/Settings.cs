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
        public String APIURLHost { get; set; }
        public Boolean IsTimeTrigger { get; set; }
        public String TimeTrigger { get; set; }
    }
}
