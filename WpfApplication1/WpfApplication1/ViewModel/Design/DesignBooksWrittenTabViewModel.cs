using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;

namespace WpfApplication1.ViewModel.Design
{
    public class DesignBooksWrittenTabViewModel
        : IBooksWrittenTabViewModel
    {

        public List<string> AllAvailableGenres
        {
            get { return new List<string>(new[] { "Novel", "Drama", "Fantasy", "Classic", "Folklore", "Mythology " ,"Sports" }); }
        }

        public IBook SelectedBook { get { return this.BooksWritten[0]; } set{throw new InvalidOperationException();}}


        public ObservableCollection<IBook> BooksWritten
        {
            get
            {
                return
                    new ObservableCollection<IBook>(new[]
                    {new Book("Tout seul", "Sports"), new Book("Mon dico passioné du football", "Sports")});
            }
        }
    }
}
