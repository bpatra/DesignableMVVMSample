/*
  In App.xaml:
  <Application.Resources>
      <vm:ViewModelLocator xmlns:vm="clr-namespace:WpfApplication1"
                           x:Key="Locator" />
  </Application.Resources>
  
  In the View:
  DataContext="{Binding Source={StaticResource Locator}, Path=ViewModelName}"

  You can also use Blend to do all this with the tool's support.
  See http://www.galasoft.ch/mvvm
*/

using System;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Ioc;
using Microsoft.Practices.ServiceLocation;
using Ninject;
using WpfApplication1.ViewModel.Design;

namespace WpfApplication1.ViewModel
{
    public class ViewModelLocator
    {
        private static readonly IKernel _kernel;

        static ViewModelLocator()
        {
            _kernel = new StandardKernel();
            if (ViewModelBase.IsInDesignModeStatic)
            {
                _kernel.Bind<IMainViewModel>().To<DesignMainViewModel>();
            }
            else
            {
                _kernel.Bind<IMainViewModel>().To<MainViewModel>().InSingletonScope();
            }

        }

        public static IMainViewModel MainViewModel { get { return _kernel.Get<IMainViewModel>(); } }

    }
}