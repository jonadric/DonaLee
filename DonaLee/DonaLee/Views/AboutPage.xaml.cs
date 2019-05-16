using DonaLee.Models;
using System;
using System.Windows.Input;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DonaLee.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AboutPage : ContentPage
    {
        public ICommand OpenWaCommand { get; }

        public AboutPage()
        {
            InitializeComponent();
            webView.Source = "https://www.google.com/maps/search/?api=1&query=4.6420318,-74.0544994";

        }
        public AboutPage( Libro _libroLoquiero)
        {
            
            InitializeComponent();
            webView.Source = "https://www.google.com/maps/search/?api=1&query=4.6420318,-74.0544994";
            Uri newUri = new Uri ("https://api.whatsapp.com/send?phone="+ _libroLoquiero.idUser +"&text= Hola amigo mio");
            OpenWaCommand = new Command(() => Device.OpenUri(newUri));

        }
    }
}