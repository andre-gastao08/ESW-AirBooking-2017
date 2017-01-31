using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AirBookingESW17.Models
{
    public class Reserva: IValidatableObject

    {

        [Key]
        public int Id { get; set; }
        [DataType(DataType.Date, ErrorMessage ="a data inserida é invalida")]
        [DisplayFormat(DataFormatString = "{0: yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public  DateTime Data { get; set; }
        [Display(Name ="Preço")]
        public decimal Preco { get; set; }
        public string UserId { get; set; }
        public ApplicationUser User { get; set; }
        public int VooId { get; set; }
        public  Voo Voos { get; set; }
        public virtual ICollection<ReservaAviao> ResAvioes { get; set; }
        public virtual ICollection<Servico> Servicos { get; set;}


        // verificação de datas ao inserir num determinado model.

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            List<ValidationResult> res = new List<ValidationResult>();
            if (Data < DateTime.Today)
            {
                ValidationResult mss = new ValidationResult("a data inserida deve ser superio ou igual a de hoje");
                res.Add(mss);

            }
            return res;

        }
    }
   
}
