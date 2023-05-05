using Microsoft.AspNetCore.Mvc;

namespace CulinaryMap.Controllers
{
    public class RecipeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
