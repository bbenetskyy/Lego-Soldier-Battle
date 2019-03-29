using MvvmCross.ViewModels;

namespace BrickWars.Core.Models
{
    public class WarriorModel : BaseModel
    {
        private WarriorType type;
        private bool isAlive;

        public WarriorType Type
        {
            get => type;
            set => SetProperty(ref type, value);
        }

        public bool IsAlive
        {
            get => isAlive;
            set => SetProperty(ref isAlive, value);
        }

        public MvxObservableCollection<EquipmentModel> Equipments { get; set; }
    }
}