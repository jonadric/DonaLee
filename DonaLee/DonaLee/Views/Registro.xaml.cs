using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DonaLee.Models;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DonaLee.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Registro : ContentPage
    {
        conection conection = new conection();
        public Registro()
        {
            InitializeComponent();
        }
        protected async override void OnAppearing()
        {
            base.OnAppearing();
            var allUsers = await conection.GetAllUsers();
            lstUsers.ItemsSource = allUsers;
        }

        private async void BtnRegistrar(Object sender, EventArgs args)
        {
            await conection.AddPerson(txtCorreo.Text, txtNombre.Text,txtApellido.Text,txtContrasenia.Text);
            txtCorreo.Text = string.Empty;
            txtNombre.Text = string.Empty;
            txtApellido.Text = string.Empty;
            txtContrasenia.Text = string.Empty;
            await DisplayAlert("Success", "Person Added Successfully", "OK");
            var allUsers = await conection.GetAllUsers();
            lstUsers.ItemsSource = allUsers;
            await Navigation.PushModalAsync(new Login());
        }
                
    }

}