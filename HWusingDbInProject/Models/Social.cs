using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HWusingDbInProject.Models
{
    public class Social
    {
        public int Id { get; set; }
        public string Link { get; set; }
        public string Icon { get; set; }
        public int EmployeeId { get; set; }
        public Employee Employee { get; set; }
    }
}
