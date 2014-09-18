using GalaSoft.MvvmLight;

namespace WpfApplication1.ViewModel
{
    public class ViewModelLocator
    {
        public static class ServiceLocator
        {
            public static IBasicVM VM;
        }

        public ViewModelLocator()
        {
            if (ViewModelBase.IsInDesignModeStatic)
            {
                ServiceLocator.VM = new DesignBasicVM();
            }
            else
            {
                ServiceLocator.VM = new BasicVm();
            }
        }


        public IBasicVM Get { get { return ServiceLocator.VM; } }
    }

  
}