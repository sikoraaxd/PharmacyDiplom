using PharmacyDiplom.MVVM.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PharmacyDiplom.MVVM.ViewModel
{
    internal class PharmsViewModel
    {
        public List<PharmacyItem> Pharms { get; set; }
        public PharmsViewModel()
        {
            Pharms = new List<PharmacyItem>();

            using (var context = new ApplicationContext())
            {
                foreach (var pharmItem in context.PharmacyItems.ToList())
                {
                    Pharms.Add(new PharmacyItem
                    {
                        ID = pharmItem.ID,
                        Name = pharmItem.Name,
                        Price = pharmItem.Price,
                        Image = pharmItem.Image,
                    });
                }
            }

            Pharms = Pharms.OrderBy(x => x.Name).ThenBy(x => x.Price).ToList();
        }
    }
}
