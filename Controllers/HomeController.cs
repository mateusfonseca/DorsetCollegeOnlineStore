﻿using System.Diagnostics;
using DorsetCollegeOnlineStore.Data;
using Microsoft.AspNetCore.Mvc;
using DorsetCollegeOnlineStore.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace DorsetCollegeOnlineStore.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private readonly DorsetCollegeOnlineStoreContext _context;

    public HomeController(ILogger<HomeController> logger, DorsetCollegeOnlineStoreContext context)
    {
        _logger = logger;
        _context = context;
    }

    public async Task<IActionResult> Index(string productCategory, string searchString, int? userId)
    {
        // Use LINQ to get list of genres.
        IQueryable<string> categoryQuery =
            from p in _context.Product
            orderby p.Category
            select p.Category;
        var products = from p in _context.Product
            select p;

        if (!string.IsNullOrEmpty(searchString))
        {
            products = products.Where(s => s.Title!.Contains(searchString));
        }

        if (!string.IsNullOrEmpty(productCategory))
        {
            products = products.Where(x => x.Category == productCategory);
        }

        var productCategoryVm = new ProductCategoryViewModel
        {
            Categories = new SelectList(await categoryQuery.Distinct().ToListAsync()),
            Products = await products.ToListAsync()
        };

        var username = from u in _context.User
            where u.Id == userId
            select u;
        
        if (username.Any())
            ViewData["Username"] = username.Single().FirstName;

        return View(productCategoryVm);
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel {RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier});
    }
}