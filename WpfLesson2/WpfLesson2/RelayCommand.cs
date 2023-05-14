using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace WpfLesson2
{
    internal class RelayCommand<T> : ICommand
    {
        private Action<T> _execute;

        public event EventHandler? CanExecuteChanged;

        public RelayCommand(Action<T> execute)
        {
            _execute = execute;
        }

        public bool CanExecute(object? parameter)
        {
            return true;
        }

        public void Execute(object? parameter)
        {
            _execute.Invoke((T)parameter);
        }
    }
}
