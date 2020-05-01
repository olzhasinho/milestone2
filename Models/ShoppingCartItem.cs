using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ArtShop3.Models
{
    public class ShoppingCartItem
    {
        public int ShoppingCartItemId { get; set; }
        public Art Art { get; set; }
        public int Amount {get;set;}
        public string ShoppingCartId { get; set; }

     
    }
}
