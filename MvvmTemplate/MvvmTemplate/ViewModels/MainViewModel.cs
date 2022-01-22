using Caliburn.Micro;

namespace MvvmTemplate.ViewModels
{
    public class MainViewModel : Screen
    {
        private string _firstName = "Khalil";
        private string _lastName = "Khalaf";

        public string FirstName
        {
            get
            {
                return _firstName;
            }
            set
            {
                _firstName = value;
                NotifyOfPropertyChange(() => FullName); // this notifies the change to whoever binded to FullName property
            }
        }
        public string LastName
        {
            get
            {
                return _lastName;
            }
            set
            {
                _lastName = value;
                NotifyOfPropertyChange(() => FullName); // this notifies the change to whoever binded to FullName property
            }
        }
        public string FullName
        {
            get
            {
                return $" { FirstName } { LastName } ";
            }

        }


    }
}
