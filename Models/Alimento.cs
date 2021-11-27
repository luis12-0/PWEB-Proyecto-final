using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Prueba6.Models
{
    [Table("Alimento")]
    public partial class Alimento
    {
        [Required]
        [StringLength(50)]
        public string ArticuloAlimentos { get; set; }
        [Required]
        [StringLength(255)]
        public string DescripcionAlimentos { get; set; }
        public int PrecioAlimentos { get; set; }
        [Required]
        [StringLength(500)]
        public string ImagenAlimentos { get; set; }
        [Key]
        [Column("IDAlimentos")]
        public int Idalimentos { get; set; }
    }
}
