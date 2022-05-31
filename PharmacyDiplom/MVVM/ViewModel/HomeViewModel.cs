using PharmacyDiplom.MVVM.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PharmacyDiplom.MVVM.ViewModel
{

    internal class HomeViewModel
    {
        public ObservableCollection<PharmacyItem> Pharms { get; set; }
        public HomeViewModel()
        {
            Pharms = new ObservableCollection<PharmacyItem>();

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

            using (var context = new ApplicationContext())
            {
                if(context.Users.ToList().Count == 0)
                {
                    User adminUser = new User();
                    adminUser.ID = Guid.NewGuid();
                    adminUser.FIO = "admin";
                    adminUser.Login = "admin";
                    adminUser.Password = "admin";
                    adminUser.Role = "Администратор";
                    context.Users.Add(adminUser);
                    context.SaveChanges();
                }
            }
        }

    }
}
