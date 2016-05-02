using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    [Table("Customer")]
    public class Customer
    {
        [Key]
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required(ErrorMessage = "El Nombre es requerido")]
        [Display(Name = "Nombre:")]
        [MaxLength(50)]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "El Telefono es requerido")]
        [Display(Name = "Telefono:")]
        [RegularExpression("^[0-9]{11,}", ErrorMessage = "Por favor, ingrese un telefono de 11 digitos")]
        public string Telefono { get; set; }

        [Display(Name = "Correo Electronico")]
        [Required(ErrorMessage = "El Correo Electronico es requerido")]
        [RegularExpression(@"^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}
                            \.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\
                            .)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$",
                        ErrorMessage = "Correo Electronico no valido")]
        public string Correo { get; set; }

        [Required(ErrorMessage = "El Usuario es requerido")]
        [Display(Name = "Usuario:")]
        [MinLength(3), MaxLength(10)]
        public string NombreUsuario { get; set; } 
    }
}
