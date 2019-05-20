using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DonaLee.Models;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DonaLee.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Login : ContentPage
    {
        conection conection = new conection();
        public Usuario UserApp;
        public Login()
        {
            InitializeComponent();
            this.BindingContext = this;
            this.IsBusy = false;
        }
        protected async override void OnAppearing()
        {
            base.OnAppearing();
            var allUsers = await conection.GetAllUsers();
            //lstUsers.ItemsSource = allUsers;
        }

        async private void BtnEnter_Clicked(Object sender, EventArgs e)
        {
            this.IsBusy = true;
            UserApp = await conection.GetUser(txtCorreo.Text);
            if (UserApp != null)
            {
                // txtCorreo.Text = User.IdUsuario.ToString();
                if (txtContrasenia.Text == UserApp.ContraseniaUsuario)
                {
                    this.IsBusy = false;
                    await DisplayAlert("DonaLee", "Bienvenido", "OK");
                    App.Current.Properties["id_User"] = UserApp.IdUsuario.ToString();
                    App.Current.MainPage = new MainPage();
                }
                else
                {
                    await DisplayAlert("Error", "Contraseña incorrecta", "OK");
                }
            }
            else
            {
                await DisplayAlert("Error", "Usuario invalido", "OK");
                this.IsBusy = false;
            }

            // Debug.Write("Entro a LoginBtn");
            // var profile = new Perfil();
            // Application.Current.MainPage = new MaestroDetalle(profile);
            //Navigation.RemovePage(this);


            // await Navigation.PushAsync(new MainPage());
        }

         private void BtnToReg_Clicked(object sender, EventArgs e)
        {

             Navigation.PushModalAsync(new Registro());
           // Navigation.RemovePage(this);
            //await Navigation.PushAsync(new Registro());
        }

    }
}