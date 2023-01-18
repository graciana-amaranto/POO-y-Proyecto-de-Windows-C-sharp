using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WindowsEFDatos.Models
{
    [Table("Avion")]
    public class Avion
    {
        [Key]
        public int AvionId { get; set; }
        public int Capacidad { get; set; }

        [Column(TypeName ="varchar")]
        [StringLength(50)]
        [Required]
        public string Denominacion { get; set; }

        [ForeignKey("LineaAereaId")]
        public LineaAerea LineaAerea { get; set; }
    }
}
//public Categoria Categoria { get; set; } // ^me genera autom. una clave foranea a la que le quiero cambiar el nombre a CategoriaId
//#endregion
