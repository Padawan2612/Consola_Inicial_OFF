using Microsoft.AspNetCore.Mvc;


namespace WebApplication1.Controllers
{
    public class CalculosController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
