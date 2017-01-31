using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AirBookingESW17.Models
{
    public class CidadeDestino
    {
        [Key]
        public int CidadeDestinoId { get; set; }
        [StringLength(255, ErrorMessage = " tamanho maximo é 255 caracteres")]
        [Required(ErrorMessage = "{0} é obrigatorio")]
        public string Nome { get; set; }
       
    }
}
