using Microsoft.AspNetCore.Mvc;
using SiteFF.Models;
using System.Diagnostics;

namespace SiteFF.Controllers
{
    public class FuncionarioController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

    }
}
