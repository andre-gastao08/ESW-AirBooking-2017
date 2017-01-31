using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AirBookingESW17.Models
{
    public class ContaNotificacao
    {

        [Key]
        public int ContaNotId { get; set; }
        [StringLength(255, ErrorMessage ="{0} maximo de caracteres"), Required]
        public string Descricao { get; set;}
        public string UserId { get; set; }
        public ApplicationUser User { get; set;}
        public int NotificacaoId { get; set; }
        public Notificacao Notificacoes { get; set;}
    }
}
