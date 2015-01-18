using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WpfApplication1.ViewModel;

namespace WpfApplication1
{
    public class Person : IPerson
    {
        public string Name { get; set; }

        public int Age { get; set; }

        public IBook[] Books { get; set; }
    }
}
