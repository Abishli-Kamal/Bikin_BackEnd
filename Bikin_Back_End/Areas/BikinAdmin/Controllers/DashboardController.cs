using Microsoft.AspNetCore.Mvc;

namespace Bikin_Back_End.Areas.BikinAdmin.Controllers
{
    [Area("BikinAdmin")]
    public class DashboardController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
