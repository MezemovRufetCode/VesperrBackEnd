using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HWusingDbInProject.Models
{
    public class CardFeature
    {
        public int Id { get; set; }
        public string Type { get; set; }
        public int Price { get; set; }
        public string  MeasureTime { get; set; }
        public string Feature1 { get; set; }
        public string Feature2 { get; set; }
        public string Feature3 { get; set; }
        public string Feature4 { get; set; }
        public string Feature5 { get; set; }
        public string ClassParameter { get; set; }
        public string Link { get; set; }
        public List<CardFeaturesBuyCard> CardFeaturesBuyCards { get; set; }
    }
}
