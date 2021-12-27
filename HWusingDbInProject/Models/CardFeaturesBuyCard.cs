using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HWusingDbInProject.Models
{
    public class CardFeaturesBuyCard
    {
        public int Id { get; set; }
        public int CardFeatureId { get; set; }
        public CardFeature CardFeature { get; set; }
        public int BuyCardId { get; set; }
        public BuyCard BuyCard { get; set; }
    }
}
