using System;
using System.Windows.Input;

using Xamarin.Forms;

namespace DonaLee.ViewModels
{
    public class AboutViewModel : BaseViewModel
    {
        public AboutViewModel()
        {
            Title = "Sobre DonaLee";

            OpenWebCommand = new Command(() => Device.OpenUri(new Uri("https://api.whatsapp.com/send?phone=+573192134510&text=Hola%20quiero%20ese%20libro%20+%20%22Perro%20come%20perro%22")));
        }

        public ICommand OpenWebCommand { get; }
    }
}