using PharmacyDiplom.Core;
using System.Windows.Input;

namespace PharmacyDiplom.MVVM.ViewModel
{
    internal class MainPageViewModel : ObservableObject
    {
        public ICommand AuthCommand { get; }
        public ICommand CartCommand { get; }

        public RelayCommand HomeViewCommand { get; set; }
        public RelayCommand PharmsViewCommand { get; set; }



        public HomeViewModel HomeVM { get; set; }
        public PharmsViewModel PharmsVM { get; set; }



        private object _currentMainPageView;
        public object CurrentMainPageView
        {
            get { return _currentMainPageView; }
            set { 
                _currentMainPageView = value;
                OnPropertyChanged();
            }
        }



        public MainPageViewModel(NavigationStore navigationStore)
        {
            AuthCommand = new NavigationCommand<AuthViewModel>(navigationStore, () => new AuthViewModel(navigationStore));
            CartCommand = new NavigationCommand<CartViewModel>(navigationStore, () => new CartViewModel(navigationStore));

            HomeVM = new HomeViewModel();
            PharmsVM = new PharmsViewModel();
            CurrentMainPageView = HomeVM;

            HomeViewCommand = new RelayCommand(o =>
            {
                CurrentMainPageView = HomeVM;
            });

            PharmsViewCommand = new RelayCommand(o =>
            {
                CurrentMainPageView = PharmsVM;
            });


        }
    }
}
