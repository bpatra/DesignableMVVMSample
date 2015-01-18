using System;
using System.Collections.Generic;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Messaging;
using WpfApplication1.ViewModel.Design;

namespace WpfApplication1.ViewModel
{

    //HARDCODED values, not realistic implementation for the example... but you get the idea put your true logic here !!!
    public class MainViewModel : ViewModelBase, IMainViewModel
    {
        private IPerson _selectedPerson;
        private List<IPerson> _availablePersons;

        public static string[] List = new[] { "Novel", "Drama", "Fantasy", "Classic", "Folklore", "Mythology " };
        
        public MainViewModel()
        {
            
            _availablePersons = new List<IPerson>(new[]
                {
                   
                    new Person(){Name = "John Doe", Age = 30, Books = new IBook[]{ new Book( "Animal Farm" ,List[0]), new Book( "1984",List[2])}}, 
                    new Person(){Name = "Sophie Germain", Age = 45, Books = new[]{new Book( "Les Misérables" ,List[1]), new Book( "Notre Dame de Paris",List[4]), }},
                    new Person(){Name = "Pierre de Fermat", Age = 20, Books = new[]{new Book( "La Curée" ,List[3]), new Book( "La bête humaine",List[0]),new Book( "Germinal",List[2])}},
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
                RaisePropertyChanged(() => BooksWrittenTabViewModel);
            }
        }
        public IList<IPerson> AvailablePersons { get { return _availablePersons; } }
        public int SelectedTabIndex { get; set; }

        public ISummaryTabViewModel SummaryTabViewModel
        {
            get { return new SummaryTabViewModel(_selectedPerson); }
        }

        public IBooksWrittenTabViewModel BooksWrittenTabViewModel
        {
            get { {return new BooksWrittenTabViewModel(_selectedPerson);} }
        }
    }
}