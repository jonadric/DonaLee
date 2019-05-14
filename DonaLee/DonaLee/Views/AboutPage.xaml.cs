using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DonaLee.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AboutPage : ContentPage
    {
        public AboutPage()
        {
            InitializeComponent();
            webView.Source = "https://www.google.com/maps/search/?api=1&query=58.698017,-152.522067";
        }
    }
}