using MvvmCross;
using MvvmCross.IoC;
using MvvmCross.ViewModels;
using MvvmCrossMoveParametersBetweenTabs.Core.Models;
using MvvmCrossMoveParametersBetweenTabs.Core.Services;
using MvvmCrossMoveParametersBetweenTabs.Core.ViewModels.Home;

namespace MvvmCrossMoveParametersBetweenTabs.Core
{
    public class App : MvxApplication
    {
        public override void Initialize()
        {
            Mvx.IoCProvider.RegisterType<IModelGenerator<User>, UserGenerator>();
            RegisterAppStart<HomeViewModel>();
        }
    }
}
