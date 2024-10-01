using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SofariDb;
using YSofaris.Models;

namespace YSofaris.Controllers;

public class HomeController(SOFARIDB context) : Controller
{
    // async Task<IActionResult>
    //int idCategory
    /*
        
    
    public HomeController(SOFARIDB context)
    {
        _context=context;
    }
     */
    public async Task<IActionResult> Index(int id)
    {
        var products =await context.Products.Include(product=>product.Category).
            Where(product=>product.Category.Id==id)
            .ToListAsync();
        return View(products);
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
