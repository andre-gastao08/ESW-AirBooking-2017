using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AirBookingESW17.Models.ManageViewModels
{
    /// <summary>
    /// Classe não utilizada, pelo que foi gerada automaticamente com o módulo da autenticação.
    /// </summary>
    public class VerifyPhoneNumberViewModel
    {
        [Required]
        public string Code { get; set; }

        [Required]
        [Phone]
        [Display(Name = "Phone number")]
        public string PhoneNumber { get; set; }
    }
}
