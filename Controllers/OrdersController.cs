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
    public class OrdersController : Controller
    {
        private readonly DorsetCollegeOnlineStoreContext _context;

        public OrdersController(DorsetCollegeOnlineStoreContext context)
        {
            _context = context;
        }

        // GET: Orders
        public async Task<IActionResult> Index()
        {
            if (Session.UserId == null)
                return RedirectToAction("Index", "Users");

            var allOrders = await _context.Order.ToListAsync();
            var userOrders = allOrders.FindAll(o => o.UserId == Session.UserId);

            return View(userOrders);
        }

        // GET: Orders/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var order = await _context.Order
                .FirstOrDefaultAsync(m => m.Id == id);
            if (order == null)
            {
                return NotFound();
            }

            var orderProducts = await _context.OrderProduct.ToListAsync();

            if (orderProducts.Count > 0)
            {
                orderProducts = orderProducts.FindAll(op => op.OrderId == id).OrderBy(cp => cp.ProductId).ToList();

                if (orderProducts.Count < 1)
                    return NotFound();

                var productsIds = orderProducts.Select(cp => cp.ProductId).ToList();
                var productsQtties = orderProducts.Select(cp => cp.Quantity).ToList();

                var orderProductsVm = new OrderProductViewModel
                {
                    Quantities = productsIds.Zip(productsQtties, (k, v) => new {k, v})
                        .ToDictionary(x => x.k, x => x.v),
                    OrderId = order.Id,
                    ProductsIds = productsIds,
                    Products = _context.Product.ToListAsync().Result
                        .Where(p => productsIds.Contains(p.Id)).ToList()
                };

                var subtotal = orderProductsVm.Products.Select(p =>
                    p.Price * orderProducts.Single(cp => cp.ProductId == p.Id)!.Quantity).ToList();

                orderProductsVm.Subtotals = productsIds.Zip(subtotal, (k, v) => new {k, v})
                    .ToDictionary(x => x.k, x => x.v);

                orderProductsVm.TotalPrice = orderProductsVm.Subtotals.Values.Aggregate(0M, (acc, sub) => acc + sub);

                return View(orderProductsVm);
            }

            return View();
        }

        // GET: Orders/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Orders/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,UserId,Date")] Order order)
        {
            if (ModelState.IsValid)
            {
                _context.Add(order);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }

            return View(order);
        }

        // GET: Orders/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var order = await _context.Order.FindAsync(id);
            if (order == null)
            {
                return NotFound();
            }

            return View(order);
        }

        // POST: Orders/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,UserId,Date")] Order order)
        {
            if (id != order.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(order);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!OrderExists(order.Id))
                    {
                        return NotFound();
                    }

                    throw;
                }

                return RedirectToAction(nameof(Index));
            }

            return View(order);
        }

        // GET: Orders/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var order = await _context.Order
                .FirstOrDefaultAsync(m => m.Id == id);
            if (order == null)
            {
                return NotFound();
            }

            return View(order);
        }

        // POST: Orders/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var order = await _context.Order.FindAsync(id);
            _context.Order.Remove(order!);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool OrderExists(int id)
        {
            return _context.Order.Any(e => e.Id == id);
        }
    }
}