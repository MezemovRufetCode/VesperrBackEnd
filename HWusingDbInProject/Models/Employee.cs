using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HWusingDbInProject.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Position { get; set; }
        public string Image { get; set; }
        public List<Social> Socials { get; set; }
    }
}
