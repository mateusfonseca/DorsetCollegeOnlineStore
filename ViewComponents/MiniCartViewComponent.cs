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

using DorsetCollegeOnlineStore.Controllers;
using DorsetCollegeOnlineStore.Data;
using DorsetCollegeOnlineStore.Models;
using Microsoft.AspNetCore.Mvc;

namespace DorsetCollegeOnlineStore.ViewComponents;

public class MiniCartViewComponent : ViewComponent
{
    private readonly DorsetCollegeOnlineStoreContext _context;

    public MiniCartViewComponent(DorsetCollegeOnlineStoreContext context)
    {
        _context = context;
    }

    public async Task<IViewComponentResult> InvokeAsync()
    {
        var model = await new CartsController(_context).MiniCart() ??
                    new CartProductViewModel
                    {
                        CartId = -1
                    };

        return await Task.FromResult<IViewComponentResult>(View(model));
    }
}