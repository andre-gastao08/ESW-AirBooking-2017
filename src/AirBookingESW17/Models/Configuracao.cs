using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AirBookingESW17.Models
{
    public class Configuracao
    {

        [Key]
        public int ConfigId { get; set; }
        [StringLength(255,MinimumLength =6, ErrorMessage ="o minimo de caracteres é 6 ")]
        public string AntigaPassword { get; set; }

        [Required(ErrorMessage ="{0} é obrigatorio")]
        public string NovaPassword { get; set; }
        [StringLength(255, ErrorMessage = "{0} é maximo de caracteres é 255")]
        [DataType(DataType.EmailAddress), Required(ErrorMessage = "{0} é obrigatorio")]
        public string Email { get; set; }
        public string UserId { get; set;}
        public ApplicationUser Users { get; set;}
        


    }
}
