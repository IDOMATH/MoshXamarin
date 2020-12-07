using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
        private ObservableCollection<Contact> _contacts;
        public Demo()
        {
            InitializeComponent();
            //var names = new List<ContactGroup>
            //{
            //    new ContactGroup("B", "B")
            //    {
            //        new Contact { Name = "Blane", ImageUrl = "http://lorempixel.com/100/100/people/1" }
            //    },
            //    new ContactGroup("M", "M")
            //    {
            //        new Contact { Name = "Mosh", ImageUrl = "http://lorempixel.com/100/100/people/2", Status="Hey, let's talk" }
            //    }

            //};
            //listView.ItemsSource = names;
            _contacts = new ObservableCollection<Contact>
            {
                new Contact { Name = "Blane", ImageUrl = "http://lorempixel.com/100/100/people/1" },
                new Contact { Name = "Mosh", ImageUrl = "http://lorempixel.com/100/100/people/2", Status="Hey, let's talk" }
            };
            listView.ItemsSource = _contacts;
        }
        List<Contact> GetContacts()
        {
            var contacts = new List<Contact>
            {
                new Contact { Name = "John", ImageUrl = "http://lorempixel.com/100/100/people/3" },
                new Contact { Name = "Bill", ImageUrl = "http://lorempixel.com/100/100/people/4" }
            };

            return contacts;
        }

        private void listView_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            var contact = e.Item as Contact;
            DisplayAlert("Tapped", contact.Name, "OK");
        }

        private void listView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            //var contact = e.SelectedItem as Contact;
            //DisplayAlert("Selected", contact.Name, "OK");
            listView.SelectedItem = null;
        }

        private void Call_Clicked(object sender, EventArgs e)
        {
            var menuItem = sender as MenuItem;
            var contact = menuItem.CommandParameter as Contact;
            DisplayAlert("Call", contact.Name, "OK");
        }

        private void Delete_Clicked(object sender, EventArgs e)
        {
            var contact = (sender as MenuItem).CommandParameter as Contact;
            _contacts.Remove(contact);
        }

        private void listView_Refreshing(object sender, EventArgs e)
        {
            _contacts = GetContacts() as ObservableCollection<Contact>;
        }

        private void SearchBar_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}