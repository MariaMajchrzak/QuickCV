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
            StartCommand = new RelayCommand(_navigateToForm);

        }
        public ICommand StartCommand { get; private set; }
        private void _navigateToForm()
        {
           _navigator.CurrentViewModel = new FormViewModel(); // todo : refactor this(mv shouldn create another vm)
        }
        private Navigator _navigator;
    }
}