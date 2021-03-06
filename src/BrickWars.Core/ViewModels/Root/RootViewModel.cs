using System;
using System.Collections.Generic;
using System.Text;
using MvvmCross.Navigation;
using BrickWars.Core.ViewModels.Home;
using BrickWars.Core.ViewModels.Menu;

namespace BrickWars.Core.ViewModels.Root
{
    public class RootViewModel : BaseViewModel
    {
        readonly IMvxNavigationService navigationService;

        public RootViewModel(IMvxNavigationService navigationService)
        {
            this.navigationService = navigationService;
        }

        public override async void ViewAppearing()
        {
            base.ViewAppearing();

            await navigationService.Navigate<MenuViewModel>();
            await navigationService.Navigate<HomeViewModel>();
        }
    }
}
