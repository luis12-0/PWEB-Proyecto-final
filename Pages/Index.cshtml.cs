using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Prueba6.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Prueba6.Pages
{
    public class IndexModel : PageModel
    {
        private readonly Prueba6.Data.ApplicationDbContext _context;

        public IndexModel(Prueba6.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<Alimento> Alimento { get; set; }

        public async Task OnGetAsync()
        {
            Alimento = await _context.Alimento.ToListAsync();
        }
    }
}
