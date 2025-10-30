namespace QuickCV.ViewModel
{
    public class MainWindowViewModel : ViewModelBase
    {
        public ViewModelBase CurrentViewModel => _navigator.CurrentViewModel;
        public MainWindowViewModel(Navigator navigator)
        {
            _navigator = navigator;
            _navigator.CurrentViewModel =  new HomeViewModel();
            
        }
        
        private readonly Navigator _navigator;
    }
}