﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;

namespace WpfApplication1.ViewModel.Design
{
    public class DesignBooksReadTabViewModel
        : IBooksReadTabViewModel
    {

        public List<string> AllAvailableGenres
        {
            get { return new List<string>(new[] { "Novel", "Drama", "Fantasy", "Classic", "Folklore", "Mythology " ,"Sports" }); }
        }

        public IBook SelectedBook { get { return this.BooksRead[0]; } set{throw new InvalidOperationException();}}


        public ObservableCollection<IBook> BooksRead
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
