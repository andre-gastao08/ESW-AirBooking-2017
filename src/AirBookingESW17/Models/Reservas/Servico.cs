using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AirBookingESW17.Models
{
    public class Servico
    {

        [Key]
        public int Id { get; set; }
        [StringLength(100, ErrorMessage ="{0} o maximo de caracteres")]
        public string Descricao { get; set; }
        [DataType(DataType.Currency)]
        public decimal Preco { get; set;}
        public int AviaoId { get; set; }
        public Aviao Avioes { get; set;}
        public int ReservaId { get; set;}
        public Reserva Reservas { get; set;}


    }
}
