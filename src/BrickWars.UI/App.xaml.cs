﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xamarin.Forms;

namespace BrickWars.UI
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

#if DEBUG
            HotReloader.Current.Start(this);
#endif
        }
    }
}
