using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HWusingDbInProject.Models
{
    public class MoreService
    {
        public int Id { get; set; }
        public string StyleParameter { get; set; } //style deyisirdi,style.css ni ozum qurdalamadim,db den gondermek duz olmaya biler tebii ki
        public string Image { get; set; }
        public int Delay { get; set; }
        public string Title { get; set; }
        public string CardText { get; set; }
    }
}
