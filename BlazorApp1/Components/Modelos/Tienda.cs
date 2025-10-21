using System.ComponentModel.DataAnnotations;

namespace ExamenSegundaParcial.Pages
{
    public class Producto
    {
        [Range(1, int.MaxValue, ErrorMessage = "Debe ser entero positivo mayor a 0")]
        public int Codigo { get; set; }

        [Required(ErrorMessage = "El nombre no debe ser vacío")]
        [StringLength(200, ErrorMessage = "La longitud máxima del nombre es de 200 caracteres")]
        public string? Titulo { get; set; }

        [Required(ErrorMessage = "Debe seleccionar departamento")]
        public string? Area { get; set; }
    }
}
