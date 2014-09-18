using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WpfApplication1
{
    class DesignBasicVM : IBasicVM
    {
        public string GetContent
        {
            get { return "Design time content"; }
        }
    }
}
