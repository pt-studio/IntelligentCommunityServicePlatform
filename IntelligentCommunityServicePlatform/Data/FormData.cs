using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace IntelligentCommunityServicePlatform.Data
{
    public class FormData
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Identity { get; set; }
        public string PermanentAddress { get; set; }
        public string Location { get; set; }
        public string Description { get; set; }
        public int ReportForId { get; set; }
        public string StreamId { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
