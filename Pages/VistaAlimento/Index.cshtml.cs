using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Prueba6.Data;
using Prueba6.Models;

namespace Prueba6.Pages.VistaAlimento
{
    public class IndexModel : PageModel
    {
        private readonly Prueba6.Data.ApplicationDbContext _context;

        public IndexModel(Prueba6.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<Alimento> Alimento { get;set; }

        public async Task OnGetAsync()
        {
            Alimento = await _context.Alimento.ToListAsync();
        }
    }
}
