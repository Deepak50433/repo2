using Cart_Example.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Cart_Example.Controllers
{
    public class PurchaseController : Controller
    {
        private CRContext _context;
        private IHttpContextAccessor _accessor;
        public PurchaseController(CRContext context, IHttpContextAccessor accessor)
        {
            _context = context;
            _accessor = accessor;
        }



        public IActionResult GetCategories()
        {
            return View(_context.catogeries.ToList());
        }



        [Authorize]
        public IActionResult GetProducts(int id)
        {
            return View(_context.Products.Where(e => e.categid == id).ToList());
        }
        [HttpPost]
        public IActionResult GetProducts(List<Product> plist)
        {
            foreach (Product p in plist)
            {
                if (p.check)
                {
                    Cart c = new Cart()
                    {
                        prodid = p.id,
                        categid = p.categid,
                        Date = DateTime.Now,
                        user = _accessor.HttpContext.User.Identity.Name
                    };
                    _context.carts.Add(c);
                    _context.SaveChanges();
                }
            }
            return RedirectToAction("GetCategories");
        }
    }
}
