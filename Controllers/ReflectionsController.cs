using Microsoft.AspNetCore.Mvc;

namespace Portfolio.Controllers
{
    public class ReflectionsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
