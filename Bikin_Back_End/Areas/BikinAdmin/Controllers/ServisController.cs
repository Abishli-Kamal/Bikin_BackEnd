using Bikin_Back_End.DAL;
using Bikin_Back_End.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Bikin_Back_End.Areas.BikinAdmin.Controllers
{
    [Area("BikinAdmin")]
    public class ServisController : Controller
    {
        private readonly AppDbContext _context;

        public ServisController(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            List<ServicesM> services = await _context.Servicess.ToListAsync();
            return View(services);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [AutoValidateAntiforgeryToken]
        public async Task<IActionResult> Create(ServicesM services)
        {
            if (!ModelState.IsValid) return View();
            await _context.Servicess.AddAsync(services);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        public async Task<IActionResult> Edit(int id)
        {
            ServicesM servicesM = await _context.Servicess.FirstOrDefaultAsync(s => s.Id == id);
            return View(servicesM);
        }
        [HttpPost]
        [AutoValidateAntiforgeryToken]
        public async Task<IActionResult> Edit(int id, ServicesM services)
        {
            ServicesM existedservis = await _context.Servicess.FirstOrDefaultAsync(s => s.Id == id);
            if (existedservis == null) return View();
            if (existedservis.Id != services.Id) return View();

            existedservis.Title = services.Title;
            existedservis.Description = services.Description;
            existedservis.Icon = services.Icon;
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));

        }
        public async Task<IActionResult> Delete(int id)
        {
            ServicesM servicesM = await _context.Servicess.FirstOrDefaultAsync(s => s.Id == id);
            return View(servicesM);
        }

        [HttpPost]
        [AutoValidateAntiforgeryToken]
        [ActionName(nameof(Delete))]

        public async Task<IActionResult> DeleteServis(int id)
        {
            ServicesM servicesM = await _context.Servicess.FirstOrDefaultAsync(s => s.Id == id);
            _context.Servicess.Remove(servicesM);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));

        }
        public async Task<IActionResult> Detail(int id)
        {
            ServicesM servicesM = await _context.Servicess.FirstOrDefaultAsync(s => s.Id == id);
            return View(servicesM);
        }
    }
}
