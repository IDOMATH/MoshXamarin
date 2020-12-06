using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace HelloWorld
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Demo : ContentPage
    {
        public Demo()
        {
            InitializeComponent();
            var names = new List<ContactGroup>
            {
                new ContactGroup("B", "B")
                {
                    new Contact { Name = "Blane", ImageUrl = "http://lorempixel.com/100/100/people/1" }
                },
                new ContactGroup("M", "M")
                {
                    new Contact { Name = "Mosh", ImageUrl = "http://lorempixel.com/100/100/people/2", Status="Hey, let's talk" }
                }
                
            };
            listView.ItemsSource = names;
        }

        private void listView_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            var contact = e.Item as Contact;
            DisplayAlert("Tapped", contact.Name, "OK");
        }

        private void listView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var contact = e.SelectedItem as Contact;
            DisplayAlert("Selected", contact.Name, "OK");
        }
    }
}