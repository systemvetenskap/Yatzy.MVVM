using System;
using System.Windows.Input;
/// <summary>
/// Definierar vilken action (metod) som ska köras på givet kommando
/// </summary>
namespace Yatzy.MVVM
{
    class RelayCommand : ICommand
    {
        private Action action;

        public event EventHandler CanExecuteChanged;

        public RelayCommand(Action action)
        {
            this.action = action;
        }

        /// <summary>
        /// Metoden kan alltid exekveras
        /// </summary>
        /// <param name="parameter"></param>
        /// <returns></returns>
        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            action();
        }
    }
}
