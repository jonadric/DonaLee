using DonaLee.Models;
using System;
using System.Windows.Input;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;


namespace DonaLee.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class EntregaPage : ContentPage
    {
        public ICommand EntregaCommand { get; }
        public EntregaPage()    
        {
            InitializeComponent();
            //EntregaCommand = new Command(() => Device.OpenUri( new Uri ("https://api.whatsapp.com/send?phone=+573133980136&text=Hola%20quiero%20ese%20libro%20%22Perro%20come%20perro%22")));


        }
        public EntregaPage(Libro _libroLoquiero)
        {

            InitializeComponent();
            
            //Uri newUri = new Uri("https://api.whatsapp.com/send?phone="+_libroLoquiero.idUser+"&text= Hola amigo mio");
            //EntregaCommand = new Command(() => Device.OpenUri(newUri));

        }

    }
}