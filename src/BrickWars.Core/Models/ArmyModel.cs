using System.Collections.Specialized;
using System.Text;
using MvvmCross.ViewModels;

namespace BrickWars.Core.Models
{
    public class ArmyModel : BaseModel
    {
        private string name;

        public string Name
        {
            get => name;
            set => SetProperty(ref name, value);
        }

        public MvxObservableCollection<WarriorModel> Warriors { get; }
        public WarriorsSummary SoldiersSummary { get; }
        public WarriorsSummary VehicleSummary { get; }
        public WarriorsSummary TanksSummary { get; }

        public ArmyModel()
        {
            Warriors = new MvxObservableCollection<WarriorModel>();
            Warriors.CollectionChanged += Warriors_CollectionChanged;

            SoldiersSummary = new WarriorsSummary(WarriorType.Soldier);
            VehicleSummary = new WarriorsSummary(WarriorType.Vehicle);
            TanksSummary = new WarriorsSummary(WarriorType.Tank);
        }

        protected void Warriors_CollectionChanged(object sender, NotifyCollectionChangedEventArgs e)
        {
            SoldiersSummary.UpdateSummary(Warriors);
            VehicleSummary.UpdateSummary(Warriors);
            TanksSummary.UpdateSummary(Warriors);
        }
    }
}