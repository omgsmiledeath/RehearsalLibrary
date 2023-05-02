using Microsoft.AspNetCore.Mvc;

namespace RehearsalAspNet.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index() => View();

    }
}
