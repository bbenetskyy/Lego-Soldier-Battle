using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using BrickWars.Core.FakeData;
using BrickWars.Core.Models;
using MvvmCross.ViewModels;

namespace BrickWars.Core.ViewModels.Home
{
    public class HomeViewModel : BaseViewModel
    {
        public MvxObservableCollection<ArmyModel> ArmyList { get; set; }

        public override Task Initialize()
        {
            ArmyList = new MvxObservableCollection<ArmyModel>(FakeDataProvider.FakeArmyModels);
            return base.Initialize();
        }
    }
}
