/*
 Dorset College Dublin
 BSc in Science in Computing & Multimedia
 Object-Oriented Programming - BSC20921
 Stage 2, Semester 2
 Continuous Assessment 2
 
 Student Name: Mateus Fonseca Campos
 Student Number: 24088
 Student Email: 24088@student.dorset-college.ie
 
 Submission date: 8 May 2022
*/

#nullable disable

using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using DorsetCollegeOnlineStore.Data;
using DorsetCollegeOnlineStore.Models;

namespace DorsetCollegeOnlineStore.Controllers
{
    public class CartProductsController : Controller
    {
        private readonly DorsetCollegeOnlineStoreContext _context;

        public CartProductsController(DorsetCollegeOnlineStoreContext context)
        {
            _context = context;
        }

        // GET: CartProducts
        public async Task<IActionResult> Index()
        {
            return View(await _context.CartProduct.ToListAsync());
        }

        // GET: CartProducts/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cartProduct = await _context.CartProduct
                .FirstOrDefaultAsync(m => m.Id == id);
            if (cartProduct == null)
            {
                return NotFound();
            }

            return View(cartProduct);
        }

        // GET: CartProducts/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: CartProducts/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,CartId,ProductId,Quantity")] CartProduct cartProduct)
        {
            if (ModelState.IsValid)
            {
                _context.Add(cartProduct);
                await _context.SaveChangesAsync();
            }

            return View();
        }

        // POST: CartProducts/Add
        [HttpPost]
        public async Task<IActionResult> Add(int quantity, int productId)
        {
            if (Session.UserId == null)
                return RedirectToAction("Index", "Users");
            
            var cartProduct = new CartProduct
            {
                CartId = _context.Cart.ToList().Find(c => c.UserId == Session.UserId)!.Id,
                ProductId = productId,
                Quantity = quantity
            };

            await Create(cartProduct);
            return RedirectToAction("Details", "Carts");
        }

        // GET: CartProducts/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cartProduct = await _context.CartProduct.FindAsync(id);
            if (cartProduct == null)
            {
                return NotFound();
            }

            return View(cartProduct);
        }

        // POST: CartProducts/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,CartId,ProductId,Quantity")] CartProduct cartProduct)
        {
            if (id != cartProduct.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(cartProduct);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CartProductExists(cartProduct.Id))
                    {
                        return NotFound();
                    }

                    throw;
                }

                return RedirectToAction(nameof(Index));
            }

            return View(cartProduct);
        }

        // GET: CartProducts/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cartProduct = await _context.CartProduct
                .FirstOrDefaultAsync(m => m.Id == id);
            if (cartProduct == null)
            {
                return NotFound();
            }

            return View(cartProduct);
        }

        // POST: CartProducts/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var cartProduct = await _context.CartProduct.FindAsync(id);
            _context.CartProduct.Remove(cartProduct!);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CartProductExists(int id)
        {
            return _context.CartProduct.Any(e => e.Id == id);
        }
    }
}