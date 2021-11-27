using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Prueba6.Data;
using Prueba6.Models;

namespace Prueba6.Pages.VistaMiCarrito
{
    public class DeleteModel : PageModel
    {
        private readonly Prueba6.Data.ApplicationDbContext _context;

        public DeleteModel(Prueba6.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public MiCarrito MiCarrito { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            MiCarrito = await _context.MiCarrito.FirstOrDefaultAsync(m => m.IdmiCarrito == id);

            if (MiCarrito == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            MiCarrito = await _context.MiCarrito.FindAsync(id);

            if (MiCarrito != null)
            {
                _context.MiCarrito.Remove(MiCarrito);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
