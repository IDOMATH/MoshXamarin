using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ExcerciseQuotes
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class QuotesPage : ContentPage
    {
        private int _index = 0;
        private string[] _quotes = new string[] { "quote1", "quote2", "quote3", "quote4" };
        public QuotesPage()
        {
            InitializeComponent();
            fontSizeSlider.Value = 16;
            quoteLabel.Text = _quotes[_index];
        }
        public void NextQuoteButtonHandler(object sender, EventArgs e)
        {
            _index = (_index + 1) % _quotes.Length;
            quoteLabel.Text = _quotes[_index];
        }
    }
}