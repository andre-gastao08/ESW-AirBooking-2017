using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AirBookingESW17.Models
{
    public class ReservaAviao
    {

   

        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "{0} é obrigatorio")]
        public string Origem { get; set; }
        [Required(ErrorMessage ="{0} é obrigatorio")]
        public string Destino { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0: yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime DataIda { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0: yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime DataRegresso { get; set; }
        [ForeignKey("ReservaId")]
        public int ReservaId { get; set; }
        public Reserva Reservas { get; set;}
        public int AviaoId { get; set; }
        public Aviao Avioes { get; set;}
        

    }

    


}
