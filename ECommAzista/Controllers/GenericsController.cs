using Microsoft.AspNetCore.Mvc;

namespace ECommAzista.Controllers
{
    public class GenericsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
