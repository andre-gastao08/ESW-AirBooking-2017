using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AirBookingESW17.Models.ManageViewModels
{
    /// <summary>
    /// Classe criada para o desenvolvimento da secção de Preferências, no entanto inacabada e não funcional, para guardar informação das escolhas do utilizador.
    /// </summary>
    /// <remarks>
    /// As propriedades QuestionID, QuestionBody, CorrectAnswer, AlternativeAnser e SelectedAnswer(a opção que o utilizador selecciona) são para a elaboração do questionário.
    /// </remarks>
    public class PreferencesViewModel
    {
        /// <summary>
        /// Gets or sets a value indicating whether the user wants to receive newsletters.
        /// </summary>
        /// <value>
        ///   <see langword="true" /> if ; otherwise, <see langword="false" />.</value>
        /// <remarks>Associação com a checkbox "Pretendo receber newsletters" da view Preferences</remarks>
        public bool newsletter { set; get; }

        public int QuestionID { get; set; }
        public string QuestionBody { get; set; }
        public string CorrectAnswer { get; set; }
        public string AlternativeAnswer { get; set; }

        public string SelectedAnswer { get; set; }
    }
}
