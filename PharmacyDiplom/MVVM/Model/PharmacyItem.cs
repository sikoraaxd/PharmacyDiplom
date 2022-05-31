using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PharmacyDiplom.MVVM.Model
{
    internal class PharmacyItem
    {
        public Guid ID { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public string Category { get; set; }
        public string Image { get; set; }
        public string Description { get; set; }

        public List<PharmMarket> PharmMarkets { get; set; } = new List<PharmMarket>();
    }
}
