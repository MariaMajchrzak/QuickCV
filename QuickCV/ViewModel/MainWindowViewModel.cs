using System;
using System.Runtime.CompilerServices;

namespace QuickCV.ViewModel
{
    public class MainWindowViewModel : ViewModelBase
    {
        public ViewModelBase CurrentViewModel => _navigator.CurrentViewModel;
        public MainWindowViewModel(Navigator navigator)
        {
            _navigator = navigator;
            _navigator.ViewModelChanged += _onViewModelChange;
            _navigator.CurrentViewModel =  new HomeViewModel( _navigator);
        }
        
        private void _onViewModelChange(object sender, EventArgs e)
        {
            OnPropertyChanged(nameof(CurrentViewModel));
        }

        private readonly Navigator _navigator;
    }
}