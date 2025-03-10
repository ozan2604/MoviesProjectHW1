using Microsoft.AspNetCore.Mvc;

namespace WebServerHW1_MoviesProject.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
