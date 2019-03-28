using System;
using System.Collections.Generic;
using System.Text;
using MvvmCross.ViewModels;

namespace BrickWars.Core.Models
{
    public class BaseModel: MvxNotifyPropertyChanged
    {
        private Guid id;
        private string image;
        private int points;

        public Guid Id
        {
            get => id;
            set => SetProperty(ref id, value);
        }

        public string Image
        {
            get => image;
            set => SetProperty(ref image, value);
        }

        public int Points
        {
            get => points;
            set => SetProperty(ref points, value);
        }
    }

    public class ArmyModel  : BaseModel
    {
        private string name;

        public string Name
        {
            get => name;
            set => SetProperty(ref name, value);
        }

        public MvxObservableCollection<WarriorModel> Warriors { get; set; }
    }

    public class WarriorModel:BaseModel
    {
        private WarriorType type;

        public WarriorType Type
        {
            get =>type;
            set => SetProperty(ref type, value);
        }

        public MvxObservableCollection<Equipment> Equipments { get; set; }
    }

    public class Equipment : BaseModel
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
            get =>isBroken;
            set => SetProperty(ref isBroken, value);
        }
    }

    public enum EquipmentType
    {
        Gun,
        Armor
    }

    public enum WarriorType
    {
        Soldier,
        Vehicle,
        Tank
    }
}
