using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ArtShop3.Models;
using ArtShop3.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ArtShop3.Controllers
{
    public class ArtController : Controller
    {
        private readonly IArtRepository _artRepository;
        private readonly ICategoryRepository _categoryRepository;
        private readonly AppDbContext _context;

        public ArtController(IArtRepository artRepository, ICategoryRepository categoryRepository, AppDbContext context)
        {
            _artRepository = artRepository;
            _categoryRepository = categoryRepository;
            _context = context;
        }
        
        [Authorize]
        public IActionResult Favorites()
        {
            
            var favoritesViewModel = new FavoritesViewModel
            {
                FavoriteArts = _artRepository.FavoriteArts
            };

            return View(favoritesViewModel);
        }
        //public ViewResult List()
        //{
        //    ArtsListViewModel artsListViewModel = new ArtsListViewModel();
        //    artsListViewModel.Arts = _artRepository.AllArts;
        //    artsListViewModel.CurrentCategory = "Dead Inside";
        //    return View(artsListViewModel); 
        //}

        public IActionResult Details(int id)
        {
            var art = _artRepository.GetArtById(id);
            if (art == null)
                return NotFound();

            return View(art);
        }

        public IActionResult SearchList(string search = null)
        {

            if (!string.IsNullOrEmpty(search))
            {
                var foundArts = _artRepository.SearchArts(search);
                return View(new FoundViewModel
                {
                    FoundArts = foundArts
                });
            }
            return View("");
        }
        public ViewResult List(string category)
        {
            IEnumerable<Art> arts;
            string currentCategory;

            if (string.IsNullOrEmpty(category))
            {
                arts = _artRepository.AllArts.OrderBy(p => p.ArtId);
                currentCategory = "All arts";
            }
            else
            {
                arts = _artRepository.AllArts.Where(p => p.Category.CategoryName == category)
                    .OrderBy(p => p.ArtId);
                currentCategory = _categoryRepository.AllCategories.FirstOrDefault(c => c.CategoryName == category)?.CategoryName;
            }

            return View(new ArtsListViewModel
            {
                Arts = arts,
                CurrentCategory = currentCategory
            });


        }



    }
}
