using Microsoft.AspNetCore.Mvc;

namespace SushiEShop.Web
{
    public class CartController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
