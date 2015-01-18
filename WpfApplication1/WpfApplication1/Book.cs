using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WpfApplication1;

namespace WpfApplication1
{
    public class Book : IBook
    {
        public Book(string title, string genre)
        {
            Title = title;
            Genre = genre;
        }

        public string Title { get; set; }
        public string Genre { get; set; }

    }
}
