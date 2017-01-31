using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AirBookingESW17.Models
{
    public class Notificacao
    {

        [Key]
        public int NotificacaoId { get; set; }
        [StringLength(255, ErrorMessage ="{0} o maximo de caracteres é 255")]
        public string Descricao { get; set;}
        [DataType(DataType.Date)]
        public DateTime DataNotificacao { get; set;}
        public int NewsletterId { get; set; }
        public Newsletter NewsLetters { get; set;}
        public virtual ICollection<ContaNotificacao> ContaNotif { get; set;}




    }
}
