using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ExercisesImages
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            var imageSource = new UriImageSource { Uri = new Uri("http://lorempixel.com/1920/1080/city/1/") };
            imageSource.CachingEnabled = false;
        }
    }
}
