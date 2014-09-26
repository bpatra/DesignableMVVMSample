using System.Collections.Generic;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Messaging;
using WpfApplication1.ViewModel.Design;

namespace WpfApplication1.ViewModel
{
   
    public class MainViewModel : ViewModelBase, IMainViewModel
    {
        private IPerson _selectedPerson;
        private List<IPerson> _availablePersons;
        public MainViewModel()
        {
            _availablePersons = new List<IPerson>(new[]
                {
                    new Person(){Name = "John Doe", Age = 30, BooksRead = new IBook[]{ new Book( "Animal Farm" ,0), new Book( "1984",2)}}, 
                    new Person(){Name = "Sophie Germain", Age = 45, BooksRead = new[]{new Book( "Les Misérables" ,1), new Book( "Notre Dame de Paris",4), }},
                    new Person(){Name = "Pierre Fermat", Age = 20, BooksRead = new[]{new Book( "La Curée" ,3), new Book( "La bête humaine",0),new Book( "Germinal",2)}},
                });
            _selectedPerson = _availablePersons[1];
        }

        public IPerson SelectedPerson
        {
            get { return _selectedPerson; }
            set
            {
                _selectedPerson = value;
                RaisePropertyChanged(()=>SummaryTabViewModel);
                RaisePropertyChanged(() => BooksReadTabViewModel);
            }
        }
        public IList<IPerson> AvailablePersons { get { return _availablePersons; } }
        public int SelectedTabIndex { get; set; }

        public ISummaryTabViewModel SummaryTabViewModel
        {
            get { return new SummaryTabViewModel(_selectedPerson); }
        }


        public IBooksReadTabViewModel BooksReadTabViewModel
        {
            get { {return new BooksReadTabViewModel(_selectedPerson);} }
        }
    }
}