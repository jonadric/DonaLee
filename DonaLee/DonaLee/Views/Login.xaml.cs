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
        
         private void BtnEnter_Clicked(Object sender, EventArgs e)
        {

            // Debug.Write("Entro a LoginBtn");
            // var profile = new Perfil();
            // Application.Current.MainPage = new MaestroDetalle(profile);
             App.Current.MainPage=new MainPage();
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