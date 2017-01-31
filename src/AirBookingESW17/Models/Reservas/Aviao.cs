using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AirBookingESW17.Models
{
    public class Aviao
    {

        public bool partilhado;
        public bool reservado;

        [Key]
        public int Id { get; set;}   
        [Required(ErrorMessage ="{0} é obrigatorio")]
        public string AvNome { get; set; }
        [Required]
        public string AvSerie { get; set; }
        [Required(ErrorMessage ="{0} é obrigatorio")]
        public int AvCapacidade { get; set; }
        // verificar se está partilhado ou não
        public bool AvPartilhado { get { return partilhado; } set{ this.partilhado = value;} }
        public int VooId { get; set; }
        public  Voo Voos{get; set;}
        public int FrotaId { get; set; }
        public Frota Frotas { get; set;}
        public virtual ICollection<ReservaAviao> ReservaAviao { get; set; }
        public virtual ICollection<Servico> Servicos { get; set;}


    }
}
