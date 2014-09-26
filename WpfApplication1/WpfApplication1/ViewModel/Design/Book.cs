using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WpfApplication1.ViewModel.Design
{
    public class Book : IBook
    {
        public Book(string title, string role)
        {
            Title = title;
            Genre = role;
        }

        public string Title { get; set; }
        public string Genre { get; set; }
    }
}
