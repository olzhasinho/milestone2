using ArtShop3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ArtShop3.ViewModels
{
    public class FavoritesViewModel
    {
        public IEnumerable<Art> FavoriteArts { get; set; }
    }
}
