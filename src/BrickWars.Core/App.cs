using MvvmCross.IoC;
using MvvmCross.ViewModels;
using BrickWars.Core.ViewModels.Root;

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
