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
        public Login()
        {
            InitializeComponent();
        }
        protected async override void OnAppearing()
        {
            base.OnAppearing();
            var allUsers = await conection.GetAllUsers();
            lstUsers.ItemsSource = allUsers;
        }

        async private void BtnEnter_Clicked(Object sender, EventArgs e)
        {
           /* var allUsers = await conection.GetAllUsers();
            for (int i = 0; i < allUsers.Count; i++)
            {
                if (allUsers[i].CorreoUsuario== txtCorreo.Text && allUsers[i].ContraseniaUsuario == txtContrasenia.Text)
                {
                    App.Current.MainPage = new MainPage();
                    txtContrasenia.Text = "";
                    txtCorreo.Text = "";
                    break;
                }
                else
                {
                    await DisplayAlert("Alert", "Verfica contraseña o usuario", "OK");
                }
            }*/


            var User = await conection.GetPerson(txtCorreo.Text);
            if (User != null)
            {
                // txtCorreo.Text = User.IdUsuario.ToString();
                if (txtContrasenia.Text == User.ContraseniaUsuario)
                {
                    await DisplayAlert("DonaLee", "Bienvenido", "OK");
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