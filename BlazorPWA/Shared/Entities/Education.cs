using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorPWA.Shared
{
   public class Education
    {
        public string University { get; set; }
        public string Course { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public string Certification { get; set; }
    }
}
