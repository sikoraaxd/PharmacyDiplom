using PharmacyDiplom.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace PharmacyDiplom.MVVM.ViewModel
{
    internal class AuthViewModel : ObservableObject
    {
        public ICommand AdminCommand { get; }

        public RelayCommand TryLogin { get; }

        public string Login { get; set; }
        public string Password { get; set; }


        public AuthViewModel(NavigationStore navigationStore)
        {
            AdminCommand = new NavigationCommand<AdminViewModel>(navigationStore, () => new AdminViewModel(navigationStore));

            TryLogin = new RelayCommand(o =>
            {
                if (Login == "" || Password == "")
                    return;
                using (ApplicationContext context = new ApplicationContext())
                {
                    foreach (var teacher in context.Users.ToList())
                    {
                        if (teacher.Login == Login && teacher.Password == Password)
                        {
                            AdminCommand.Execute(this);
                            return;
                        }
                    }
                }
            });
        }
    }
}
