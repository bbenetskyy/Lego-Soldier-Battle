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
                    Image = "https://cdn2.iconfinder.com/data/icons/helmet/512/roman-warrior-soldier-helmet-hat-512.png";
                    break;
                case WarriorType.Vehicle:
                    Image = "https://cdn.iconscout.com/icon/premium/png-256-thumb/army-truck-3-1049325.png";
                    break;
                case WarriorType.Tank:
                    Image = "https://cdn.iconscout.com/icon/premium/png-256-thumb/tank-132-772283.png";
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