using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using Ninject;

namespace WpfApplication1.ViewModel
{
    public class BooksReadTabViewModel : IBooksReadTabViewModel
    {
        private IPerson _person;


        [Inject]
        public BooksReadTabViewModel(IPerson person)
        {
            _person = person;
        }

        public ObservableCollection<IBook> BooksRead { get{return new ObservableCollection<IBook>(_person.Books);} }

        public List<string> AllAvailableGenres
        {
            get { return new List<string>(MainViewModel.List); }
        }

        public IBook SelectedBook { get; set; }
    }
}
