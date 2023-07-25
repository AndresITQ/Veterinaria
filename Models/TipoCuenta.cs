using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace Veterinaria.Models
{
    public class TipoCuenta
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        [StringLength(maximumLength: 50, MinimumLength = 3,
            ErrorMessage = "La longitud del campo {0} debe estar " +
            "entre los datos {2} y {1} caracteres")]
        public string Nombre { get; set; }
        public int UsuarioId { get; set; }
        public int Orden { get; set; }

        /*Pruebas de validaciones por defecto*/
        [Required(ErrorMessage = "El campo {0} es requerido")]
        [EmailAddress(ErrorMessage = "El campo {0} debe ser un Email")]
        public string Email { get; set; }
        [Required(ErrorMessage = "El campo {0} es requerido")]
        [Range(minimum: 18, maximum: 65, ErrorMessage = "La edad debe estar entre {1} y {2}")]
        public int Edad { get; set; }
        [Required(ErrorMessage = "El campo {0} es requerido")]
        [Url(ErrorMessage = "La informacion de la url debe ser valida")]
        public string URL { get; set; }
        [CreditCard(ErrorMessage = "El numero de la tarjeta de credito debe ser valida")]
        [Display(Name = "Tarjeta De Credito")]
        public string TarjetaDeCredito { get; set; }

    }
}

