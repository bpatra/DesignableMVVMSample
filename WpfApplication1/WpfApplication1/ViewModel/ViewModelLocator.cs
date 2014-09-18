using System;
using GalaSoft.MvvmLight;
using Ninject;

namespace WpfApplication1.ViewModel
{
    public class ViewModelLocator
    {
         private readonly IKernel _kernel;
        

        public ViewModelLocator()
        {
            var kernel = new StandardKernel();
            if (ViewModelBase.IsInDesignModeStatic)
            {
                 kernel.Bind<IBasicVM>().To<DesignBasicVM>();
            }
            else
            {
                kernel.Bind<IBasicVM>().To<BasicVm>();
            }
            _kernel = kernel;
        }


        public IBasicVM Get { get { return _kernel.Get<IBasicVM>(); } }

    }

  
}