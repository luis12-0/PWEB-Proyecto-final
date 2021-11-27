using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using Prueba6.Models;

namespace Prueba6.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Prueba6.Models.Alimento> Alimento { get; set; }
        public DbSet<Prueba6.Models.Electrodomestico> Electrodomestico { get; set; }
        public DbSet<Prueba6.Models.MiCarrito> MiCarrito { get; set; }
    }
}
