using System;
using System.Windows.Input;

using Xamarin.Forms;

namespace DonaLee.ViewModels
{
    class EntregaModel : BaseViewModel
    {

        public EntregaModel ()
        {
            Title = "Entregas DonaLee";

        }
        public ICommand EntregaCommand { get; }


    }
}
