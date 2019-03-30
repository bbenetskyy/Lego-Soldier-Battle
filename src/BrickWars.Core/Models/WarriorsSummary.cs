using System.Collections.Generic;
using System.Linq;
using MvvmCross.ViewModels;

namespace BrickWars.Core.Models
{
    public class WarriorsSummary : MvxNotifyPropertyChanged
    {
        private readonly WarriorType warriorType;
        private int warriors;
        private int aliveWarriors;

        public string Image { get; }

        public int Warriors
        {
            get => warriors;
            set => SetProperty(ref warriors, value);
        }

        public int AliveWarriors
        {
            get => aliveWarriors;
            set => SetProperty(ref aliveWarriors, value);
        }

        public string Summary => $"{AliveWarriors}/{Warriors}";

        public WarriorsSummary(WarriorType warriorType)
        {
            this.warriorType = warriorType;

            switch (warriorType)
            {
                case WarriorType.Soldier:
                    Image = "https://image.flaticon.com/icons/svg/1406/1406926.svg";
                    break;
                case WarriorType.Vehicle:
                    Image = "https://image.flaticon.com/icons/svg/1406/1406945.svg";
                    break;
                case WarriorType.Tank:
                    Image = "https://image.flaticon.com/icons/svg/1406/1406942.svg";
                    break;
            }
        }

        public void UpdateSummary(IEnumerable<WarriorModel> warriors)
        {
            var filteredWarriors = warriors
                .Where(w => w.Type == warriorType)
                .ToList();
            Warriors = filteredWarriors.Count;
            AliveWarriors = filteredWarriors.Count(w=>w.IsAlive);
            RaiseAllPropertiesChanged();
        }
    }
}