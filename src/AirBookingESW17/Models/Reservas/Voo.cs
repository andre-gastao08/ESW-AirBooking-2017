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
        public int CidadeOrigemId { get; set; }
        public int CidadeDestinoId { get; set; }
        [Required(ErrorMessage = "{0} é obrigatorio"), StringLength(255)]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0: yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime DataPartida { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0: yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime DataChegada { get; set; }
        public int TripulacaoId { get; set; }
        public Tripulacao Tripulacao { get; set;}
        public virtual ICollection<Reserva> Reservas { get; set; }
        public virtual ICollection<CidadeOrigem> Origem { get; set; }
        public virtual ICollection<CidadeDestino> Destino { get; set; }
    }
}
