using System;
using System.Windows.Input;

namespace WpfMVVMDemoApp.ViewModels.Commands
{
    internal class AddPeopleCommand : ICommand
    {
        public ViewModelBase ViewModelBase { get; set; }

        public AddPeopleCommand(ViewModelBase viewModelBase)
        {
            this.ViewModelBase = viewModelBase;
        }

        #region ICommand Interface
        event EventHandler ICommand.CanExecuteChanged
        {
            add
            {
                CommandManager.RequerySuggested += value;
            }

            remove
            {
                CommandManager.RequerySuggested -= value;
            }
        }

        bool ICommand.CanExecute(object parameter)
        {
            if (parameter is Models.Person person)
            {
                if (string.IsNullOrEmpty(person.FullName.Trim()))
                {
                    return false;
                }

                return true;
            }
            return false;
        }

        void ICommand.Execute(object parameter)
        {
            this.ViewModelBase.AddPeople(parameter as Models.Person);
        }
        #endregion
    }
}
