using System;

using DonaLee.Models;

namespace DonaLee.ViewModels
{
    public class ItemDetailViewModel : BaseViewModel
    {
        public Libro Item { get; set; }
        public ItemDetailViewModel(Libro item = null)
        {
            Title = item?.Titulo__c;
            Item = item;
        }
    }
}
