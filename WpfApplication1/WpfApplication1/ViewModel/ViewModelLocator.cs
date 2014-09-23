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
                _kernel.Bind<IMainViewModel>().To<MainViewModel>();
                _kernel.Bind<ISummaryTabViewModel>().To<DesignSummaryTabViewModel>();
                _kernel.Bind<IBooksReadTabViewModel>().To<DesignBooksReadTabViewModel>();
            }
            else
            {
               
                _kernel.Bind<IMainViewModel>().To<MainViewModel>().InSingletonScope();

                _kernel.Bind<ISummaryTabViewModel>().To<SummaryTabViewModel>();
                _kernel.Bind<IBooksReadTabViewModel>().To<BooksReadTabViewModel>();

                _kernel.Bind<IPerson>().ToMethod((ctx) =>
                {
                    var mainViewModelInstance = _kernel.Get<IMainViewModel>();
                    if (mainViewModelInstance.SelectedPerson == null)
                    {
                        throw new InvalidOperationException();
                    }
                    return mainViewModelInstance.SelectedPerson;
                });

            }

        }

        public static IMainViewModel MainViewModel { get { return _kernel.Get<IMainViewModel>(); } }

        public static ISummaryTabViewModel SummaryTabViewModel { get { return _kernel.Get<ISummaryTabViewModel>(); } }

        public static IBooksReadTabViewModel BooksReadTabViewModel { get { return _kernel.Get<IBooksReadTabViewModel>(); } }

    }
}