using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Windows.Data;
using System.Windows.Input;
using WpfMVVMDemoApp.Models;

namespace WpfMVVMDemoApp.ViewModels
{
    internal class ViewModelBase
    {
        public List<string> GenderTypes { get; set; } = new List<string> { "Male", "Female" };

        public Person Person { get; set; } = new Person();

        public ObservableCollection<Person> People { get; set; } = new ObservableCollection<Person>();




        public ICommand AddPeopleCommand { get; set; }

        public IValueConverter BackGroundConverter { get; set; } = new Converters.BackGruondConverter();

        public ViewModelBase()
        {
            this.AddPeopleCommand = new Commands.AddPeopleCommand(this);
        }

        public void AddPeople(Person person)
        {
            var newPerson = new Person(person);
            this.People.Add(newPerson);
        }
    }
}
