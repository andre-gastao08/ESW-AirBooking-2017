using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AirBookingESW17.Models
{

    
    public class Frota: IValidatableObject
    {

        [Key]
        public int FrotaId { get; set; }
        [StringLength(255, ErrorMessage = " tamanho maximo é 255 caracteres")] 
         [Required(ErrorMessage = "{0} é obrigatorio")]
        public string Nome { get; set; }
        [StringLength(255, ErrorMessage = " tamanho maximo é 255 caracteres")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        [StringLength(255, ErrorMessage="{0} tem de ter 9 digitos")]
        [Required(ErrorMessage = "{0} é obrigatorio")]
        public string Morada { get; set; }
        //[CheckDigit(9, ErrorMessage:"O {0} tem de ter 9 digitos"), Required]
        public int NIF { get; set; }
        [DataType(DataType.PhoneNumber)]
        [Required(ErrorMessage = "{0} é obrigatorio")]
        [RegularExpression(@"^(\d{9})$", ErrorMessage = "o nº do telefone de ter 9 digitos")]
        public string Telefone { get; set; }
        public virtual ICollection<Aviao> Avioes { get; set; }


        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {

            string numero = NIF.ToString();
            List<ValidationResult> res = new List<ValidationResult>();
            if (numero.Length != 9)
            {
                ValidationResult mss = new ValidationResult("o NIF deve ter 9 digitos");
                res.Add(mss);
            }

            foreach (char c in numero)
            {

                if (!Char.IsDigit(c))
                {
                    ValidationResult mss = new ValidationResult("o NIF não pode ter caracteres ");
                    res.Add(mss);
                }
            }

            return res;
        }


    }

   

}
