using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WpfApplication1.ViewModel
{
    public interface IMainViewModel
    {
        IPerson SelectedPerson { get; set; }
        IList<IPerson> AvailablePersons { get; }

        int SelectedTabIndex { get; set; }
    }
}
