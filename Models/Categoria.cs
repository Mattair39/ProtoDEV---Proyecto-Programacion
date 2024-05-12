using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace ProtoDEV___Proyecto_Programacion.Models
{
    public class Categoria
    {
        [Key]
        public int Id { get; set; }


        [DisplayName("Nombre de la Categoría")]
        [NotNull]
        [MaxLength(40,ErrorMessage ="El nombre máximo de caracteres a ingresar es de 40")]
        
        public string? nombre { get; set; }

        [DisplayName("Orden de Visualización")]
        [Range(1, 1000,ErrorMessage ="El orden de visualización debe ser entre 1-100")]
        public int ordenCategoria { get; set; }

    }
}
