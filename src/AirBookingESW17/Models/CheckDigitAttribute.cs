using System;
using System.Linq;
using System.ComponentModel.DataAnnotations;
namespace AirBookingESW17.Models
{
    public class CheckDigitAttribute : ValidationAttribute
    {
        private string messagem;
        private int digito;

        public CheckDigitAttribute(int v, string ErrorMessage)
        {
            this.digito = v;
            this.messagem = ErrorMessage;

           
        }


        public override bool IsValid(object value)
        {

            /*string []Contrib = new string[9];
            bool verificar = false;
            string[] s = new string[9];
            string Ss = null;
            string C = null;
            int i = 0;
            int checkDigit = (int)value;

            s[0] = Convert.ToString(Contrib[0]);
            s[1] = Convert.ToString(Contrib[1]);
            s[2] = Convert.ToString(Contrib[2]);
            s[3] = Convert.ToString(Contrib[3]);
            s[4] = Convert.ToString(Contrib[4]);
            s[5] = Convert.ToString(Contrib[5]);
            s[6] = Convert.ToString(Contrib[6]);
            s[7] = Convert.ToString(Contrib[7]);
            s[8] = Convert.ToString(Contrib[8]);

            if (Contrib.Length == 9)
            {
                C = s[0];
                if (s[0] == "1" || s[0] == "2" || s[0] == "5" || s[0] == "6" || s[0] == "9")
                {
                    checkDigit = Convert.ToInt32(C) * 9;
                    for (i = 2; i <= 8; i++)
                    {
                        checkDigit = checkDigit + (Convert.ToInt32(s[i - 1]) * (10 - i));
                    }
                    checkDigit = 11 - (checkDigit % 11);
                    if ((checkDigit >= 10))
                        checkDigit = 0;
                    Ss = s[0] + s[1] + s[2] + s[3] + s[4] + s[5] + s[6] + s[7] + s[8];
                    if ((checkDigit == Convert.ToInt32(s[8])))

                       return verificar= true;
                }
                else { return verificar; }

                
            }
            return verificar;
*/

            string numero = value.ToString();
            if(numero.Length != digito)
            {
                return false;
            }
            foreach(Char c in numero)
            {
                if (!Char.IsDigit(c))
                {
                    return false;
                }
               
            }
            return true;

        }
        public  string Messagem
        {
            get
            {
                return messagem= "tem de ter 9 digitos";

            }
        }
    }
}