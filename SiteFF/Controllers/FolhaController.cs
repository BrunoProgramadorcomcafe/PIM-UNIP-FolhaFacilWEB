using Microsoft.AspNetCore.Mvc;

namespace SiteFF.Controllers
{
    public class FolhaController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
