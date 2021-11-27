using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Prueba6.Models
{
    [Table("MiCarrito")]
    public partial class MiCarrito
    {
        [Required]
        [StringLength(50)]
        public string ArticuloMiCarrito { get; set; }
        [Required]
        [StringLength(255)]
        public string DescripcionMiCarrito { get; set; }
        public int PrecioMiCarrito { get; set; }
        [Required]
        [StringLength(500)]
        public string ImagenMiCarrito { get; set; }
        [Key]
        [Column("IDMiCarrito")]
        public int IdmiCarrito { get; set; }
    }
}
