using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PharmacyDiplom.MVVM.Model
{
    internal class PharmMarket
    {
        public Guid ID { get; set; }
        public string Name { get; set; }

        public List<PharmacyItem> PharmacyItems { get; set; } = new List<PharmacyItem>();
    }
}
