using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AirBookingESW17.Models
{
    public class Voo
    {

        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage ="{0} é obrigatorio"), StringLength(255)]
        public string Origem { get; set; }
        [Required(ErrorMessage = "{0} é obrigatorio"), StringLength(255)]
        public string Destino { get; set;}
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0: yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime DataPartida { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0: yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime DataChegada { get; set; }
        public int TripalacaoId { get; set; }
        public Tripulacao Tripulacao { get; set;}
        public virtual ICollection<Reserva> Reservas { get; set; }
    }
}
