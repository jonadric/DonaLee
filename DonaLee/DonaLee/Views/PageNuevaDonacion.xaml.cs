using System;
using System.Collections.Generic;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using DonaLee.Models;

namespace DonaLee.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PageNuevaDonacion : ContentPage
    {
        public Libro _libro { get; set; }
        conection conection = new conection();


        public PageNuevaDonacion()
        {
            InitializeComponent();

            _libro = new Libro
            {
                Autor__c = "",
                Descripcion__c = "",
                Imagen__c="",
                Ubicacion=new Ubicacion()
            };

            BindingContext = this;
        }

        async void Save_Clicked(object sender, EventArgs e)
        {
                await DisplayAlert("DonaLee", "Libro "+_libro.Titulo__c+" cargado.", "OK");
            // MessagingCenter.Send(this, "Añadir", _libro);


            var allBoks = await conection.GetAllBooks();
            var CodBookNuevoGenerado = allBoks[allBoks.Count -1];
            _libro.IdBook = CodBookNuevoGenerado.IdBook + 1;
            var valor = Application.Current.Properties["id_User"];
            await conection.AddBook(_libro, int.Parse(valor.ToString()));
            await Navigation.PopModalAsync();
        }

        async void Cancel_Clicked(object sender, EventArgs e)
        {
            await Navigation.PopModalAsync();
        }
    }
}