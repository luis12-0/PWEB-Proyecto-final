using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Prueba6.Models
{
    [Table("Electrodomestico")]
    public partial class Electrodomestico
    {
        [Required]
        [StringLength(50)]
        public string ArticuloElectrodomesticos { get; set; }
        [Required]
        [StringLength(255)]
        public string DescripcionElectrodomesticos { get; set; }
        public int PrecioElectrodomesticos { get; set; }
        [Required]
        [StringLength(500)]
        public string ImagenElectrodomesticos { get; set; }
        [Key]
        [Column("IDElectrodomesticos")]
        public int Idelectrodomesticos { get; set; }
    }
}
