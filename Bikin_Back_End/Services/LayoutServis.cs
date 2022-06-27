using Bikin_Back_End.DAL;
using Bikin_Back_End.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Bikin_Back_End.Services
{
    public class LayoutServis
    {
        private readonly AppDbContext _context;

        public LayoutServis(AppDbContext context)
        {
            _context = context;
        }

        public async Task<List<Setting>> GetDatas()
        {
            List<Setting> setting = await _context.Settings.ToListAsync();
            return setting;
        }
    }
}
