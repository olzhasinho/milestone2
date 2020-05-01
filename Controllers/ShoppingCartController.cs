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
    public class ShoppingCartController : Controller
    {
        private readonly IArtRepository _artRepository;
        private readonly ShoppingCart _shoppingCart;

        public ShoppingCartController(IArtRepository artRepository, ShoppingCart shoppingCart)
        {
            _artRepository = artRepository;
            _shoppingCart = shoppingCart;
        }

        public ViewResult Index()
        {
            var items = _shoppingCart.GetShoppingCartItems();
            _shoppingCart.ShoppingCartItems = items;

            var shoppingCartViewModel = new ShoppingCartViewModel
            {
                ShoppingCart = _shoppingCart,
                ShoppingCartTotal = _shoppingCart.GetShoppingCartTotal()
            };

            return View(shoppingCartViewModel);
        }

        public RedirectToActionResult AddToShoppingCart(int artId)
        {
            var selectedArt = _artRepository.AllArts.FirstOrDefault(a => a.ArtId == artId);

            if (selectedArt != null)
            {
                _shoppingCart.AddToCart(selectedArt, 1);
            }
            return RedirectToAction("Index");
        }

        public RedirectToActionResult RemoveFromShoppingCart(int artId)
        {
            var selectedArt= _artRepository.AllArts.FirstOrDefault(a => a.ArtId == artId);

            if (selectedArt != null)
            {
                _shoppingCart.RemoveFromCart(selectedArt);
            }
            return RedirectToAction("Index");
        }
    }
}
