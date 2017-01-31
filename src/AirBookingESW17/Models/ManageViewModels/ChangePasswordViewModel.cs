using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;


namespace AirBookingESW17.Models.ManageViewModels
{
    /// <summary>
    /// Esta classe faz o tratamento dos dados recebidos pela view ChangePassword que corresponde a "Definições de Conta", para alterações do nome, email, username e password.
    /// Todos os dados devem ser actualizados por valores novos, excepto pela password que necessita da anterior e da repetição da nova para confirmação.
    /// </summary>
    public class ChangePasswordViewModel
    {
        
        [Required]
        public string newFirstName { get; set; }

        [Required]
        public string newLastName { get; set; }

        [Required]
        public string newUsername { get; set; }
        
        [Required]
        [EmailAddress]
        public string newEmail { get; set; }

        [Required]
        [DataType(DataType.Password)]    
        public string OldPassword { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "A password deve ter no minimo 6 caracteres", MinimumLength = 6)]
        [DataType(DataType.Password)]      
        public string NewPassword { get; set; }

        [DataType(DataType.Password)]       
        [Compare("NewPassword", ErrorMessage = "As duas passwords estão diferentes.")]
        public string ConfirmPassword { get; set; }
    }
}
