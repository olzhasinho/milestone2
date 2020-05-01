using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ArtShop3.Models
{
    public interface IArtRepository
    {
        IEnumerable<Art> AllArts { get; }
        IEnumerable<Art> ArtsOfTheWeek { get; }
        IEnumerable<Art> FavoriteArts { get; }
        Art GetArtById(int artId);
        List<Art> GetAllArts();
        List<Art> SearchArts(string search);



    }
}
