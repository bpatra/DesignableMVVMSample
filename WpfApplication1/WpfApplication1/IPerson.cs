using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WpfApplication1
{

    public interface IPerson
    {
        string Name { get; }

        int Age { get; }

        string[] BooksRead { get;} 
    }

    public class Person : IPerson
    {
        public string Name { get; set; }

        public int Age { get; set; }

        public string[] BooksRead { get; set; } 
    }
}
