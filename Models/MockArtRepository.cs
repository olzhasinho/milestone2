/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ArtShop3.Models
{
    public class MockArtRepository : IArtRepository
    {
            
        private readonly ICategoryRepository _categoryRepository = new MockCategoryRepository();

        public IEnumerable<Art> AllArts =>
            new List<Art>
            {
                new Art {ArtId = 1, Name = "Kaneki Ken", Price=2000, Description = "Deeply Art...", CategoryId = 1, ImageThumbnailUrl = "/images/1.jpg", ImageUrl = "/images/2.jpg", InStock = false, IsArtOfTheWeek = false, Category = _categoryRepository.AllCategories.ToList()[0]},
                new Art {ArtId = 2, Name = "Naruto", Price=2000, Description = "Deeply Art...", CategoryId = 2, ImageThumbnailUrl = "/images/3.jpg", ImageUrl = "/images/4.jpg", InStock = false, IsArtOfTheWeek = false, Category = _categoryRepository.AllCategories.ToList()[1] },
                new Art {ArtId = 3, Name = "Sanu", Price=2000, Description = "Deeply Art...", CategoryId = 3, ImageThumbnailUrl = "/images/5.jpg", ImageUrl = "/images/6.jpg", InStock = false, IsArtOfTheWeek = false, Category = _categoryRepository.AllCategories.ToList()[2]}
            };
        public IEnumerable<Art> ArtsOfTheWeek { get; }

        public Art GetArtById(int artId)
        {
            return AllArts.FirstOrDefault(a => a.ArtId == artId);
        }


    }
}
*/
