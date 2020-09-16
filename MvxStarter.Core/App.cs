using MvvmCross;
using MvvmCross.ViewModels;
using MvxStarter.Core.Services;
using MvxStarter.Core.ViewModels;

namespace MvxStarter.Core
{
    public class App : MvxApplication
    {
        public override void Initialize()
        {
            Mvx.IoCProvider.RegisterType<ICalculationService, CalculationService>();
            Mvx.IoCProvider.RegisterType<IPropabilityDeterminer, OptimisticPropabilityDeterminer>();
            RegisterAppStart<TipViewModel>();
            //RegisterAppStart<GuestBookViewModel>();
        }
    }
}
