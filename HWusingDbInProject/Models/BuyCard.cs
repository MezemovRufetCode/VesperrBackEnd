using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HWusingDbInProject.Models
{
    public class BuyCard
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<CardFeaturesBuyCard> CardFeaturesBuyCards { get; set; }
    }
}
