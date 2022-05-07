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
    public class CartsController : Controller
    {
        private readonly DorsetCollegeOnlineStoreContext _context;

        public CartsController(DorsetCollegeOnlineStoreContext context)
        {
            _context = context;
        }

        // GET: Carts
        public async Task<IActionResult> Index()
        {
            return View(await _context.Cart.ToListAsync());
        }

        // GET: Carts/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            var allCarts = await _context.Cart.ToListAsync();

            if (Session.UserId != null)
                id = allCarts.Last(c => c.UserId == Session.UserId).Id;
            else
                return RedirectToAction("Index", "Users");

            var cart = await _context.Cart
                .FirstOrDefaultAsync(m => m.UserId == id);
            if (cart == null)
            {
                return NotFound();
            }

            var cartProducts = await _context.CartProduct.ToListAsync();

            if (cartProducts.Count > 0)
            {
                cartProducts = cartProducts.FindAll(cp => cp.CartId == id).OrderBy(cp => cp.ProductId).ToList();

                if (cartProducts.Count < 1)
                    return RedirectToAction("Empty");

                var productsIds = cartProducts.Select(cp => cp.ProductId).ToList();
                var productsQtties = cartProducts.Select(cp => cp.Quantity).ToList();

                var cartProductsVm = new CartProductViewModel
                {
                    Quantities = productsIds.Zip(productsQtties, (k, v) => new {k, v})
                        .ToDictionary(x => x.k, x => x.v),
                    CartId = cart.Id,
                    ProductsIds = productsIds,
                    Products = _context.Product.ToListAsync().Result
                        .Where(p => productsIds.Contains(p.Id)).ToList(),
                };

                var subtotal = cartProductsVm.Products.Select(p =>
                    p.Price * cartProducts.Single(cp => cp.ProductId == p.Id)!.Quantity).ToList();

                cartProductsVm.Subtotals = productsIds.Zip(subtotal, (k, v) => new {k, v})
                    .ToDictionary(x => x.k, x => x.v);

                cartProductsVm.TotalPrice = cartProductsVm.Subtotals.Values.Aggregate(0M, (acc, sub) => acc + sub);

                return View(cartProductsVm);
            }

            return View();
        }

        // GET: Carts/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Carts/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,UserId")] Cart cart)
        {
            if (ModelState.IsValid)
            {
                _context.Add(cart);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }

            return View(cart);
        }

        // GET: Carts/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cart = await _context.Cart.FindAsync(id);
            if (cart == null)
            {
                return NotFound();
            }

            return View(cart);
        }

        // POST: Carts/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,UserId")] Cart cart)
        {
            if (id != cart.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(cart);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CartExists(cart.Id))
                    {
                        return NotFound();
                    }

                    throw;
                }

                return RedirectToAction(nameof(Index));
            }

            return View(cart);
        }

        // GET: Carts/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cart = await _context.Cart
                .FirstOrDefaultAsync(m => m.Id == id);
            if (cart == null)
            {
                return NotFound();
            }

            return View(cart);
        }

        // POST: Carts/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var cart = await _context.Cart.FindAsync(id);
            _context.Cart.Remove(cart!);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CartExists(int id)
        {
            return _context.Cart.Any(e => e.Id == id);
        }

        // GET: Carts/Empty
        public IActionResult Empty()
        {
            return View();
        }

        // GET: Carts/CheckOut/5
        public async Task<IActionResult> CheckOut(int? id)
        {
            var order = new Order()
            {
                UserId = Session.UserId,
                Date = DateTime.Now.Date
            };

            _context.Order.Add(order);
            await _context.SaveChangesAsync();

            foreach (var cartProduct in _context.CartProduct.ToList().FindAll(cp => cp.CartId == id))
            {
                _context.OrderProduct.Add(new OrderProduct()
                {
                    OrderId = order.Id,
                    ProductId = cartProduct.ProductId,
                    Quantity = cartProduct.Quantity
                });

                _context.CartProduct.Remove(cartProduct);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction("Index", "Orders");
        }

        // GET: Carts/Remove?cartId=5&productId=5
        public async Task<IActionResult> Remove(int? productId, int? cartId)
        {
            var cartProduct = _context.CartProduct.Single(cp => cp.CartId == cartId && cp.ProductId == productId);
            _context.CartProduct.Remove(cartProduct);
            await _context.SaveChangesAsync();

            return RedirectToAction("Details", "Carts");
        }

        // GET: Carts/Update?cartId=5&productId=5&quantity=5
        public async Task<IActionResult> Update(int? cartId, int? productId, int quantity)
        {
            var cartProduct = _context.CartProduct.Single(cp => cp.CartId == cartId && cp.ProductId == productId);
            cartProduct.Quantity = quantity;
            _context.CartProduct.Update(cartProduct);
            await _context.SaveChangesAsync();

            return RedirectToAction("Details", "Carts");
        }

        public async Task<CartProductViewModel> MiniCart()
        {
            var allCarts = await _context.Cart.ToListAsync();
            int? id;

            if (Session.UserId != null)
                id = allCarts.Last(c => c.UserId == Session.UserId).Id;
            else
                return null;

            var cart = await _context.Cart
                .FirstOrDefaultAsync(m => m.UserId == id);
            if (cart == null)
            {
                return null;
            }

            var cartProducts = await _context.CartProduct.ToListAsync();

            if (cartProducts.Count > 0)
            {
                cartProducts = cartProducts.FindAll(cp => cp.CartId == id).OrderBy(cp => cp.ProductId).ToList();

                if (cartProducts.Count < 1)
                    return null;

                var productsIds = cartProducts.Select(cp => cp.ProductId).ToList();
                var productsQtties = cartProducts.Select(cp => cp.Quantity).ToList();

                var cartProductsVm = new CartProductViewModel
                {
                    Quantities = productsIds.Zip(productsQtties, (k, v) => new {k, v})
                        .ToDictionary(x => x.k, x => x.v),
                    CartId = cart.Id,
                    ProductsIds = productsIds,
                    Products = _context.Product.ToListAsync().Result
                        .Where(p => productsIds.Contains(p.Id)).ToList(),
                };

                var subtotal = cartProductsVm.Products.Select(p =>
                    p.Price * cartProducts.Single(cp => cp.ProductId == p.Id)!.Quantity).ToList();

                cartProductsVm.Subtotals = productsIds.Zip(subtotal, (k, v) => new {k, v})
                    .ToDictionary(x => x.k, x => x.v);

                cartProductsVm.TotalPrice = cartProductsVm.Subtotals.Values.Aggregate(0M, (acc, sub) => acc + sub);

                return cartProductsVm;
            }

            return null;
        }
    }
}