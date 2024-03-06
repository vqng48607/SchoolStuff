using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Printing;
using System.Text;
using System.Windows.Input;
using WPFAndMVVM2.Command;
using WPFAndMVVM2.Models;

namespace WPFAndMVVM2.ViewModels
{
    public class MainViewModel : INotifyPropertyChanged
    {
        private PersonRepository personRepo = new PersonRepository();

        // Implement the rest of this MainViewModel class below to 
        // establish the foundation for data binding !

        private ObservableCollection<PersonViewModel> personsVM;
        public ObservableCollection<PersonViewModel> PersonsVM
        {
            get { return personsVM; }
            set { personsVM = value; }
        }

        public MainViewModel()
        {
            this.PersonsVM = new ObservableCollection<PersonViewModel>();

            foreach (Person p in personRepo.GetAll())
            {
                PersonViewModel personViewModel = new PersonViewModel(p);
                personsVM.Add(personViewModel);
            }

        }

        private PersonViewModel selectedPerson;
        public PersonViewModel SelectedPerson 
        {
            get 
            { 
                return selectedPerson; 
            }
            set 
            { 
                selectedPerson = value; 
                OnPropertyChanged("SelectedPerson"); 
            }
        }

        public ICommand NewPersonCommand { get; } = new NewPersonCommand();
        public ICommand DeletePersonCommand { get; } = new DeletePersonCommand();
        public void AddDefaultPerson()
        {
            Person defaultPerson = personRepo.Add("Specify FirstName", "Specify LastName", 0, "Specify Phone");
            PersonViewModel personViewModel = new PersonViewModel(defaultPerson);
            personsVM.Add(personViewModel);

        }
        public void DeleteSelectedPerson()
        {
            SelectedPerson.DeletePerson(personRepo);
            personsVM.Remove(SelectedPerson);
        }

            
        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged(string propertyName)

        {

            PropertyChangedEventHandler propertyChanged = this.PropertyChanged;

            if (propertyChanged != null)

            {

                propertyChanged(this, new PropertyChangedEventArgs(propertyName));

            }

        }


    }
}
