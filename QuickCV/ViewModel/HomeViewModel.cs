using System;
using System.Security.Cryptography.X509Certificates;
using System.Windows.Input;

namespace QuickCV.ViewModel
{
    public class HomeViewModel : ViewModelBase
    {
        public HomeViewModel(Navigator navigator)
        {
            _navigator = navigator;
            StartCommand = new RelayCommand(NavigateToForm);

        }
        public ICommand StartCommand { get; private set; }
        private void NavigateToForm()
        {
           _navigator.CurrentViewModel = new FormViewModel(); 
        }
        private Navigator _navigator;
    }
}