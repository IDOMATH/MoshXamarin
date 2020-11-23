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
        public static class Quotes
        {
            private static int index { get; set; }
            private static readonly string[] QuoteString = new string[4] { "quote1", "quote2", "quote3", "quote4" };

            static Quotes()
            {
                index = 0;
            }

            public static string GetQuote()
            {
                var quote = QuoteString[index];
                index = (index + 1) % QuoteString.Length;
                return quote;
            }
        }
        public QuotesPage()
        {
            InitializeComponent();
            fontSizeSlider.Value = 16;
            quoteLabel.Text = Quotes.GetQuote();
        }
        public void NextQuoteButtonHandler(object sender, EventArgs e)
        {
            quoteLabel.Text = Quotes.GetQuote();
        }
    }
}