using PharmacyDiplom.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PharmacyDiplom.MVVM.ViewModel
{
    internal class AdminViewModel : ObservableObject
    {
        public RelayCommand AdminPharmsViewCommand { get; set; }
        public RelayCommand AdminUsersViewCommand { get; set; }
        public RelayCommand AdminHistoryViewCommand { get; set; }

        public AdminPharmsViewModel AdminPharmsVM { get; set; }
        public AdminUsersViewModel AdminUsersVM { get; set; }
        public AdminHistoryViewModel AdminHistoryVM { get; set; }

        private object _currentAdminView;
        public object CurrentAdminView
        {
            get { return _currentAdminView; }
            set
            {
                _currentAdminView = value;
                OnPropertyChanged();
            }
        }

        public AdminViewModel(NavigationStore navigationStore)
        {
            AdminPharmsVM = new AdminPharmsViewModel();
            AdminUsersVM = new AdminUsersViewModel();
            AdminHistoryVM = new AdminHistoryViewModel();


            CurrentAdminView = AdminPharmsVM;

            AdminPharmsViewCommand = new RelayCommand(o =>
            {
                CurrentAdminView = AdminPharmsVM;
            });

            AdminUsersViewCommand = new RelayCommand(o =>
            {
                CurrentAdminView = AdminUsersVM;
            });

            AdminHistoryViewCommand = new RelayCommand(o =>
            {
                CurrentAdminView = AdminHistoryVM;
            });
        }
    }
}
