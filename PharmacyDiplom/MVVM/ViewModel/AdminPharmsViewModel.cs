using PharmacyDiplom.Core;
using PharmacyDiplom.MVVM.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PharmacyDiplom.MVVM.ViewModel
{
    
    internal class AdminPharmsViewModel
    {
        public ObservableCollection<PharmacyItem> PharmItems { get; set; }
        public RelayCommand AddPharmItem { get; }
        public RelayCommand EditPharmItem { get; }
        public RelayCommand DeletePharmItem { get; }

        public string Name { get; set; }
        public string Price { get; set; }
        public string Category { get; set; }
        public string Image { get; set; }
        public string Description { get; set; }

        public AdminPharmsViewModel()
        {
            PharmItems = new ObservableCollection<PharmacyItem>();

            using (var context = new ApplicationContext())
            {
                foreach (var pharmItem in context.PharmacyItems.ToList())
                {
                    PharmItems.Add(new PharmacyItem
                    {
                        ID = pharmItem.ID,
                        Name = pharmItem.Name,
                        Category = pharmItem.Category,
                        Price = pharmItem.Price,
                        Image = pharmItem.Image,
                        Description = pharmItem.Description,
                    });
                }
            }

            AddPharmItem = new RelayCommand(o =>
            {
                using(var context = new ApplicationContext())
                {
                    PharmacyItem item = new PharmacyItem();
                    item.ID = Guid.NewGuid();
                    item.Name = Name;
                    item.Price = Convert.ToDouble(Price);
                    item.Category = Category; 
                    item.Image = Image;
                    item.Description = Description;
                    context.PharmacyItems.Add(item);
                    context.SaveChanges();

                    PharmItems.Add(item);
                }
            });
        }
    }
}
