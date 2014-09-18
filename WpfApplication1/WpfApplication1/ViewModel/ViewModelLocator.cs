using GalaSoft.MvvmLight;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Windows;

namespace WpfApplication1
{
    public class ViewModelLocator
    {
        public ViewModelLocator()
        {
            if (ViewModelBase.IsInDesignModeStatic)
            {
                ServiceLocator.VM = new DesignBasicVM();
            }
            else
            {
                ServiceLocator.VM = new BasicVM();
            }
        }


        public IBasicVM Get { get { return ServiceLocator.VM; } }
    }

    public static class ServiceLocator
    {
        public static IBasicVM VM;
    }
}