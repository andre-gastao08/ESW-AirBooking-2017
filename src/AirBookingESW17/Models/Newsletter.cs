using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AirBookingESW17.Models
{
    public class Newsletter
    {

        [Key]
        public int NewsletterId { get; set; }
        [StringLength(255, ErrorMessage ="{0} é maximo de caracteres é 255")]
        [Required]
        public string NomeDestinatario { get; set; }
        [StringLength(255, ErrorMessage = "{0} é maximo de caracteres é 255")]
        [DataType(DataType.EmailAddress), Required(ErrorMessage ="{0} é obrigatorio")]
        public string EmaisDestinatario { get; set;}
    }
}
