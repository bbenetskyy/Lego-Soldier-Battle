using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using BrickWars.Core.FakeData;
using BrickWars.Core.Models;
using BrickWars.Core.ViewModels.Contacts;
using MvvmCross.Navigation;
using MvvmCross.ViewModels;

namespace BrickWars.Core.ViewModels.Home
{
    public class HomeViewModel : BaseViewModel
    {
        private readonly IMvxNavigationService navigationService;
        private ArmyModel selectedArmy;

        public MvxObservableCollection<ArmyModel> ArmyList { get; set; }

        public ArmyModel SelectedArmy
        {
            get => selectedArmy;
            set
            {
                SetProperty(ref selectedArmy, value);
                if(selectedArmy != null)
                    NavigateToArmyDetailis();
            }
        }

        public HomeViewModel(IMvxNavigationService navigationService)
        {
            this.navigationService = navigationService;
        }

        private void NavigateToArmyDetailis()
        {
            navigationService.Navigate<ContactsViewModel>();
        }

        public override Task Initialize()
        {
            ArmyList = new MvxObservableCollection<ArmyModel>(FakeDataProvider.FakeArmyModels);
            return base.Initialize();
        }
    }
}
