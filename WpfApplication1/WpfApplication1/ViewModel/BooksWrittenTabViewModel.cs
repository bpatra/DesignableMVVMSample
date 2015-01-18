using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using Ninject;

namespace WpfApplication1.ViewModel
{
    public class BooksWrittenTabViewModel : IBooksWrittenTabViewModel
    {
        private IPerson _person;


        [Inject]
        public BooksWrittenTabViewModel(IPerson person)
        {
            _person = person;
        }

        public ObservableCollection<IBook> BooksWritten { get{return new ObservableCollection<IBook>(_person.Books);} }

        public List<string> AllAvailableGenres
        {
            get { return new List<string>(MainViewModel.List); }
        }

        public IBook SelectedBook { get; set; }
    }
}
