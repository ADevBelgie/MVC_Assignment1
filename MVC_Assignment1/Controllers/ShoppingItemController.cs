using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MVC_Assignment1.Data;
using MVC_Assignment1.Models;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_Assignment1.Controllers
{
    [Authorize]
    public class ShoppingItemController : Controller
    {
        private readonly MVC_Assignment1Context _context;

        public ShoppingItemController(MVC_Assignment1Context context)
        {
            _context = context;
        }

        // GET: Shoppingcart
        [Authorize]
        public async Task<IActionResult> Index()
        {
            //var productlist = await _context.ProductTShirtViewModel.ToListAsync();
            //var shoppingcart = await _context.ShoppingItemViewModel.ToListAsync();
            ////.Include(s => s.product.ID == productlist.Find(p => p.ID == ))
            dynamic mymodel = new ExpandoObject();
            mymodel.productlist = await _context.ProductTShirtViewModel.ToListAsync();
            mymodel.shoppingcart = await _context.ShoppingItemViewModel.ToListAsync();
            return View(mymodel);
        }
        [Authorize]
        public async Task<IActionResult> AddProductToCart(int id, int selectAmount = 1, string originC = "ShoppingItem", string originV = "Index")
        {
            var shoppingcart = await _context.ShoppingItemViewModel
                .ToListAsync();

            if (shoppingcart == null)
            {
                shoppingcart = new List<ShoppingItemViewModel>();

                _context.ShoppingItemViewModel.Add(new ShoppingItemViewModel()
                {
                    productID = id,
                    Amount = 1
                });
            }
            else
            {
                var productToAdd = shoppingcart.Find(p => p.productID == id);
                if (productToAdd != null)
                {
                    productToAdd.Amount+= selectAmount;
                }
                else
                {
                    _context.ShoppingItemViewModel.Add(new ShoppingItemViewModel()
                    {
                        productID = id,
                        Amount = selectAmount
                    }); ;
                }
            }
            
            await _context.SaveChangesAsync();
            if (originV == "Details")
            {
                return RedirectToAction(originV, originC, new { id = id });
            }
            else
            {
                return RedirectToAction(originV, originC);
            }
        }
        [Authorize]
        public async Task<IActionResult> RemoveProductToCart(int id, string originC = "ShoppingItem", string originV = "Index")
        {
            var shoppingcart = await _context.ShoppingItemViewModel
                .ToListAsync();

            if (shoppingcart != null)
            {
                var productToRemove = shoppingcart.Find(p => p.productID == id);
                if (productToRemove != null)
                {
                    _context.ShoppingItemViewModel.Remove(productToRemove);
                }
            }

            await _context.SaveChangesAsync();

            return RedirectToAction(originV, originC);
        }
        [Authorize]
        private bool ShoppingcartViewModelExists(int id)
        {
            return _context.ShoppingItemViewModel.Any(e => e.ID == id);
        }
    }
}
