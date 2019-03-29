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
        //public MvxObservableCollection<ArmyModel> Armies { get; set; }

        public override Task Initialize()
        {
            //Armies = new MvxObservableCollection<ArmyModel>(FakeDataProvider.FakeArmyModels);
            return base.Initialize();
        }
    }
}
