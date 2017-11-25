using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IntelligentCommunityServicePlatform.Data
{
    public class FormData
    {
        public int Id { get; set; }
        public string Location { get; set; }
        public string ReportFor { get; set; }
        public string UserId { get; set; }
        public virtual ApplicationUser User { get; set; }
    }
}
