using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Caliburn.Micro;
using WPFUI.Models;

namespace WPFUI.ViewModels
{
    public class ShellViewModel : Screen

    {

        private string _firstName = "Ozan";
        private string _lastName = "Ilter";
        private BindableCollection<PersonModel> _people = new BindableCollection<PersonModel>();
        private PersonModel _selectedPerson;


        public ShellViewModel()
        {
            People.Add(new PersonModel { FirstName = "Ozan", LastName = "Ilter" });
            People.Add(new PersonModel { FirstName = "Mehmet", LastName = "Aksu" });
            People.Add(new PersonModel { FirstName = "Hasan", LastName = "Kaya" });
        }

        public string FirstName
        {
            get { return _firstName; }
            set
            {
                _firstName = value;
                NotifyOfPropertyChange(() => FirstName);
                NotifyOfPropertyChange(() => FullName);
            }
        }

        public string LastName
        {
            get { return _lastName; }
            set
            {
                _lastName = value;
                NotifyOfPropertyChange(() => LastName);
                NotifyOfPropertyChange(() => FullName);

            }
        }

        public string FullName
        {
            get { return $"{FirstName} {LastName}"; }
        }




        public BindableCollection<PersonModel> People { get { return _people; } set { _people = value; } }

        public PersonModel SelectedPerson
        {
            get { return _selectedPerson; }
            set
            {

                _selectedPerson = value;
                NotifyOfPropertyChange(() => SelectedPerson);

            }
        }

        public void ClearText()
        {
            FirstName = "";
            LastName = "";
        }
    }
}
