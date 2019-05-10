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
        public Item Item { get; set; }

        public PageNuevaDonacion()
        {
            InitializeComponent();

            Item = new Item
            {
                Text = "Descripcion del libro",
                Description = "This is an item description."
            };

            BindingContext = this;
        }

        async void Save_Clicked(object sender, EventArgs e)
        {
            MessagingCenter.Send(this, "Añadir", Item);
            await Navigation.PopModalAsync();
        }

        async void Cancel_Clicked(object sender, EventArgs e)
        {
            await Navigation.PopModalAsync();
        }
    }
}