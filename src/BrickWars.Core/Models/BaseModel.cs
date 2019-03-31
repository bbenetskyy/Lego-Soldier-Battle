using System;
using MvvmCross.ViewModels;

namespace BrickWars.Core.Models
{
    public class BaseModel : MvxNotifyPropertyChanged
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
}