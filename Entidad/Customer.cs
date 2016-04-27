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
        [Required]
        [Display(Name = "Nombre:")]
        public string Nombre { get; set; }
        [Required]
        [Display(Name = "Telefono:")]
        public string Telefono { get; set; }
        [Required]
        [Display(Name = "Correo:")]
        public string Correo { get; set; }
        [Required]
        [Display(Name = "Nombre Usuario:")]
        public string NombreUsuario { get; set; } 
    }
}
