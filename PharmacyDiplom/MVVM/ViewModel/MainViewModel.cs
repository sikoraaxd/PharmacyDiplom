using PharmacyDiplom.Core;
using System;

namespace PharmacyDiplom.MVVM.ViewModel
{
    internal class MainViewModel : ObservableObject
    {
        private readonly NavigationStore _navigationStore;
        public ObservableObject CurrentView => _navigationStore.CurrentViewModel;
        public MainViewModel(NavigationStore navigationStore)
        {
            _navigationStore = navigationStore;
            _navigationStore.CurrentViewModelChanged += OnCurrentViewModelChanged;
        }
        private void OnCurrentViewModelChanged()
        {
            OnPropertyChanged(nameof(CurrentView));
        }
    }
}
