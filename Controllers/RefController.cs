using Microsoft.AspNetCore.Mvc;

namespace Portfolio.Controllers
{
    public class RefController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
