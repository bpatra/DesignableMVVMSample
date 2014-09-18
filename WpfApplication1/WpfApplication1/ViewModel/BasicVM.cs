using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WpfApplication1
{
    public class BasicVM : IBasicVM
    {
        public string GetContent
        {
            get { return "Runtime content"; }
        }
    }
}
