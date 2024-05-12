using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;

namespace ProtoDEV___Proyecto_Programacion.Models
{
    public class Producto
    {
        [Key]
        public int id { get; set; }

        [Required]
        [DisplayName("Nombre")]
        public string nombre { get; set; }

        [DisplayName("Descripción")]
        public string descripcion { get; set; }

        [DisplayName("Especificaciones")]
        public string especificaciones { get; set; }

        [Required]
        [DisplayName("Fabricante")]
        public string fabricante { get; set; }

        [DisplayName("SKU")]
        [Required]
        public string SKU { get; set; }

        [Required]
        [DisplayName("Precio Listado")]
        [Range(1, 10000)]
        public double precioVenta { get; set; }

        [Required]
        [DisplayName("Precio por 1-50")]
        [Range(1,10000)]
        public double precio { get; set; }

        [Required]
        [DisplayName("Precio por +50")]
        [Range(1, 10000)]
        public double precio50 { get; set; }

        [Required]
        [DisplayName("Precio por +100")]
        [Range(1, 10000)]
        public double precio100 { get; set; }


        [ForeignKey("CategoriaId")]
        [DisplayName("Categoría")]
        [AllowNull]
        public int CategoriaId { get; set; }
        [DisplayName("Categoría")]
        public Categoria? Categoria { get; set; }

        [DisplayName("URL Imagen")]

        
        public string imagenURL { get; set; }
    }
}
