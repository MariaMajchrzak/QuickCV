
using System;

namespace QuickCV.ViewModel
{
    public class Navigator 
    {
        public event EventHandler ViewModelChanged;
        public ViewModelBase CurrentViewModel 
        {
            get { return _currentViewModel; }
            set 
            {
                _currentViewModel = value; 
                ViewModelChanged?.Invoke(this, EventArgs.Empty);
            }
        }
        private ViewModelBase _currentViewModel;
    }
}