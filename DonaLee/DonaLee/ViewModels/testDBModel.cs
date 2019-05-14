using System;
using System.Windows.Input;

using Xamarin.Forms;

namespace DonaLee.ViewModels
{
    public class testDBModel : BaseViewModel
    {
        public testDBModel()
        {
            Title = "Prueba FireBase";

            OpenWebCommand = new Command(() => Device.OpenUri(new Uri("https://xamarin.com/platform")));
        }
        public ICommand OpenWebCommand { get; }

    }
        
}
