using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using BrickWars.Core.Models;
using MvvmCross.Forms.Converters;
using MvvmCross.ViewModels;

namespace BrickWars.UI.Converters
{
    public class WarriorsToImageConverter:MvxFormsValueConverter<MvxObservableCollection<WarriorModel>,string>
    {
        protected override string Convert(MvxObservableCollection<WarriorModel> value,
            Type targetType,
            object parameter,
            CultureInfo culture)
        {
            if (!Enum.TryParse(parameter?.ToString(), out WarriorType warriorType)) return String.Empty;

            switch (warriorType)
            {
                case WarriorType.Soldier:
                    return "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQRP4NdHfx6taawj9jL8w3fE-I6pYuWnn0FLqdhdSbIiDF5qrwl";
                case WarriorType.Vehicle:
                    return "https://cdn1.iconfinder.com/data/icons/military-army-vehicles-and-transportations/235/military-army-vehicles-006-512.png";
                case WarriorType.Tank:
                    return "https://static.thenounproject.com/png/23115-200.png";
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }
    }
}
