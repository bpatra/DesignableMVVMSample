﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WpfApplication1.ViewModel;

namespace WpfApplication1
{

    public interface IPerson
    {
        string Name { get; }

        int Age { get; }

        IBook[] Books { get;} 
    }
}
