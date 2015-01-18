using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace WpfApplication1.ViewModel
{
    //HARDCODED values, not realistic implementation for the example... but you get the idea put your true logic here !!!
    public class SummaryTabViewModel : ISummaryTabViewModel
    {
        private readonly IPerson _person;
        public SummaryTabViewModel(IPerson person)
        {
            _person = person;
        }

        public string Name { get { return _person.Name; } }
        public int Age { get { return _person.Age; } }
    }
}
