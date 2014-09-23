using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace WpfApplication1.ViewModel
{
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
