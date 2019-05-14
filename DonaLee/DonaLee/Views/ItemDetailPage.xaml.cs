using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using DonaLee.Models;
using DonaLee.ViewModels;

namespace DonaLee.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ItemDetailPage : ContentPage
    {
        ItemDetailViewModel viewModel;

        public ItemDetailPage(ItemDetailViewModel viewModel)
        {
            InitializeComponent();

            BindingContext = this.viewModel = viewModel;
        }

        public ItemDetailPage()
        {
            InitializeComponent();

            var item = new Libro
            {
                Titulo__c = "Item 1",
                Descripcion__c = "This is an item descriptio11111n."
            };

            viewModel = new ItemDetailViewModel(item);
            BindingContext = viewModel;

        }

       async private void BntPedir(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new AboutPage());

        }
    }
}