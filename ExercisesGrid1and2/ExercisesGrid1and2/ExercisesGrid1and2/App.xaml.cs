﻿using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ExercisesGrid1and2
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new Welcome();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
