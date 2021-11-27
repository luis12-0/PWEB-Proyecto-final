using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Prueba6.Data;
using Prueba6.Models;

namespace Prueba6.Pages.VistaMiCarrito
{
    public class CreateModel : PageModel
    {
        private readonly Prueba6.Data.ApplicationDbContext _context;

        public CreateModel(Prueba6.Data.ApplicationDbContext context)
        {
            _context = context;
        }
        public string Producto { get; set; }
        public string Descripcion { get; set; }
        public int Precio { get; set; }
        public string Imagen { get; set; }
        public IActionResult OnGet(string producto, string descripcion, int precio,
            string imagen)
        {
            Producto = producto;
            Descripcion = descripcion;
            Precio = precio;
            Imagen = imagen;
            Imagen = Imagen.Replace("%2F", "/"); 
            return Page();
        }

        [BindProperty]
        public MiCarrito MiCarrito { get; set; }

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.MiCarrito.Add(MiCarrito);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
