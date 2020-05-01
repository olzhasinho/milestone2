using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace ArtShop3.Models
{
    public class Art
    {
        public int ArtId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public decimal Price { get; set; }
        public string ImageUrl { get; set; }
        public string ImageThumbnailUrl { get; set; }
        public bool IsArtOfTheWeek { get; set; }
        public bool InStock {get; set;}

        public int CategoryId { get; set; }

        public Category Category { get; set; }

        public int ArtLike { get; set; }

        public bool IsFavorite { get; set;}



    }
}
