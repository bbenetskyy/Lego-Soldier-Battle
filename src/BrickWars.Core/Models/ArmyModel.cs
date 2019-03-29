using System.Collections.Generic;
using System.Text;
using MvvmCross.ViewModels;

namespace BrickWars.Core.Models
{
    public class ArmyModel  : PointsModel
    {
        private string name;

        public string Name
        {
            get => name;
            set => SetProperty(ref name, value);
        }

        public MvxObservableCollection<WarriorModel> Warriors { get; set; }
    }
}
