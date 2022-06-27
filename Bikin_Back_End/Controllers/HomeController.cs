using Bikin_Back_End.DAL;
using Bikin_Back_End.View_models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Bikin_Back_End.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext _context;

        public HomeController(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            HomeVM model = new HomeVM
            {
                Servicess = await _context.Servicess.ToListAsync(),
                Homes = await _context.Homes.FirstOrDefaultAsync(),
            };
            return View(model);
        }
    }
}
