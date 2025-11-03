using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace QuickCV
{
    internal class RelayCommand : ICommand
    {

        public RelayCommand(Action execute, Func<bool> canExecute = null)
        { 
            _execute = execute;
            _canExecute = canExecute;
        }


        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            return true;

        }

        public void Execute(object parameter)
        {
            _execute();
        }

        private Action _execute;
        private Func<bool> _canExecute;
    }
}
