using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ArtShop3.Models
{
    public class ArtRepository : IArtRepository
    {
        private readonly AppDbContext _appDbContext;

        public ArtRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public IEnumerable<Art> AllArts
        {
            get
            {
                return _appDbContext.Arts.Include(a => a.Category);
            }
        }

        public IEnumerable<Art> ArtsOfTheWeek
        {
            get
            {
                return _appDbContext.Arts.Include(a => a.Category).Where(a => a.IsArtOfTheWeek);
            }
        }

        public IEnumerable<Art> FavoriteArts
        {
            get
            {
                return _appDbContext.Arts.Include(a => a.Category).Where(a => a.IsFavorite);
            }

        }

        public Art GetArtById(int artId)
        {
            return _appDbContext.Arts.FirstOrDefault(a => a.ArtId == artId);
        }

        public List<Art> GetAllArts()
        {
            return _appDbContext.Arts.ToList();
        }

        public List<Art> SearchArts(string search)
        {
            return _appDbContext.Arts.Where(a => a.Name.Contains(search) || a.Description.Contains(search)).ToList();
        }


    }
}
