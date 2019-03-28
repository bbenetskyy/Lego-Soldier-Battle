using MvvmCross.IoC;
using MvvmCross.ViewModels;
using BrickWars.Core.ViewModels.Root;
using Xamarin.Forms;

namespace BrickWars.Core
{
    public class App : MvxApplication
    {
        public override void Initialize()
        {
            CreatableTypes()
                .EndingWith("Service")
                .AsInterfaces()
                .RegisterAsLazySingleton();

            RegisterAppStart<RootViewModel>();
        }
    }
}
