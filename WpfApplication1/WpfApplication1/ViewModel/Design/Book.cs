using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WpfApplication1.ViewModel.Design
{
    public class Book : IBook
    {
        public Book(string title, int idex)
        {
            Title = title;
            SelectedGenre = this.AllAvailableGenres.ElementAt(idex);
        }

        public string Title { get; set; }
        public string SelectedGenre { get; set; }

        public List<string> AllAvailableGenres
        {
            get { return new List<string>(new[] { "Novel", "Drama", "Fantasy", "Classic", "Folklore", "Mythology " }); }
        }
    }
}
