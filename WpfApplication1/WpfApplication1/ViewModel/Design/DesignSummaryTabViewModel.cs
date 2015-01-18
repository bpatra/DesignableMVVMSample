using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WpfApplication1.ViewModel.Design
{
    class DesignSummaryTabViewModel : ISummaryTabViewModel
    {
        public string Name { get { return "Raymond Domenech"; } }
        public int Age { get { return 62; } }
    }
}
