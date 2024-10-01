using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SofariDb;

namespace YSofaris.Controllers
{
    public class ProductController(SOFARIDB sOFARIDB) : Controller
    {
        public async Task<IActionResult> Details(int id)
        {
            var product = await sOFARIDB.Products.Where(product => product.Id == id).Include(product => product.productImgs).FirstAsync();
            //var product = await sOFARIDB.Products.Where(product => product.Id == id).Include(product => product.productImgs).FirstAsync();
            //var colors = await sOFARIDB.Products.Where(product => product.Title == product.Title).ToListAsync();
            return View(product);
        }
    }
}
/*
 * var productDetailsVM=new ProductDetailsVM
{
    ProductController=myProduct,
    Colors =colors
}
            return View();
        }
        public async Task<IActionResult>ChangeProduct(string title,string color)
        {
            sOFARIDB.Products.Where(product => product.Title==title&&product.).Select(product=>product.Id)
        }
 */