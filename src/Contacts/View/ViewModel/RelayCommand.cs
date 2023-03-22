using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace View.ViewModel
{
    /// <summary>
    /// Предоставляет реализацию интерфейса <see cref="ICommand"/> 
    /// </summary>
    public class RelayCommand : ICommand
    {
        /// <summary>
        /// Делегат для вызова команды.
        /// </summary>
        private Action<object> _execute;

        /// <summary>
        /// Определяет, может ли выполняться команда.
        /// </summary>
        /// <param name="parameter">Параметр.</param>
        /// <returns>Возвращает true.</returns>
        public bool CanExecute(object parameter)
        {
            return true;
        }

        /// <summary>
        /// Выполняет логику команды.
        /// </summary>
        /// <param name="parameter">Параметр.</param>
        public void Execute(object parameter)
        {
            _execute(parameter);
        }

        /// <summary>
        /// Создает экземпляр класса <see cref="RelayCommand"/>.
        /// </summary>
        /// <param name="execute">Делегат для вызова команды.</param>
        public RelayCommand(Action<object> execute)
        {
            this._execute = execute;
        }

        /// <summary>
        /// Событие, предоставляющее информацию о возможности вызова команды.
        /// </summary>
        public event EventHandler CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }
    }
}
