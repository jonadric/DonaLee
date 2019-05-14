using System;
using System.Collections.Generic;
using System.Text;

namespace DonaLee.Models
{
    public enum MenuItemType
    {
        Prueba,
        Browse,
        About
    }
    public class HomeMenuItem
    {
        public MenuItemType Id { get; set; }

        public string Title { get; set; }
    }
}
