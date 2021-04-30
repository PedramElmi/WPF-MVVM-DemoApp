using System.ComponentModel;

namespace WpfMVVMDemoApp.Models
{
    internal class Person : INotifyPropertyChanged
    {

        private string fisrtName = null;
        private string lastName = null;
        private string fullName = null;
        private string gender = null;


        public string Gender
        {
            get { return this.gender; }
            set { this.gender = value; this.OnPropertyChanged("Gender");}
        }


        public string FirstName
        {
            get { return this.fisrtName; }
            set
            {
                this.fisrtName = value;
                this.OnPropertyChanged("FirstName");
                this.OnPropertyChanged("FullName");
            }
        }

        public string LastName
        {
            get { return this.lastName; }
            set
            {
                this.lastName = value;
                this.OnPropertyChanged("LastName");
                this.OnPropertyChanged("FullName");
            }
        }


        public string FullName
        {
            get
            {
                return this.FirstName + " " + this.LastName;
            }
            set
            {
                this.fullName = value;
                this.OnPropertyChanged("FullName");
            }
        }

        /// <summary>
        /// initializes a person
        /// </summary>
        public Person()
        {

#if DEBUG
            this.FirstName = "Pedram";
            this.LastName = "Elmi";
            this.Gender = "Male";
#endif

        }

        /// <summary>
        /// initializes a person from another person
        /// </summary>
        /// <param name="person"></param>
        public Person(Person person)
        {
            this.FirstName = person.FirstName;
            this.LastName = person.LastName;
            this.Gender = person.Gender;
        }


        #region INotifyPropertyChanged Interface
        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
        #endregion
    }
}
