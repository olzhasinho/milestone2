using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ArtShop3.Models;
using ArtShop3.ViewModels;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ArtShop3.Controllers
{
    public class HomeController : Controller
    {
        private readonly IArtRepository _artRepository;
        private readonly AppDbContext _context;
        public HomeController(IArtRepository artRepository, AppDbContext context)
        {
            _artRepository = artRepository;
            _context = context;
        } 

        public IActionResult Index()
        {
            var homeViewModel = new HomeViewModel
            {
                ArtsOfTheWeek = _artRepository.ArtsOfTheWeek
            };

            return View(homeViewModel);
        }
    }
}
