namespace BrickWars.Core.Models
{
    public class EquipmentModel : BaseModel
    {
        private EquipmentType type;
        private bool isBroken;

        public EquipmentType Type
        {
            get => type;
            set => SetProperty(ref type, value);
        }

        public bool IsBroken
        {
            get => isBroken;
            set => SetProperty(ref isBroken, value);
        }
    }
}