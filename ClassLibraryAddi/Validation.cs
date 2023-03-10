using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.Remoting;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ClassLibraryAddi
{   
    /// <summary>
    /// Used for check if some string respects some conditions and return the error message if not
    /// </summary>
    public class Validation
    {
        // the error message list
        private List<string> errors = new List<string>{  "Lettre ou - uniquement.", // 0
            "Ne doit pas dépasser 30 cactères." // 1
            ,"Ne doit contenir que des chiffre.", // 2
        "Le nombre de peut pas être négatif", // 3 
        "la date doit être valide", // 4
        "la date est déja passée", // 5
        "pas plus de 5 caractère numérique"}; // 6

        // the pattern list for regex
        private List<string> patterns = new List<string> { "^[\\p{L}]{2,}(?:[-]{0,1}[\\p{L}]{2,}){0,1}$", //0
            "^[\\p{L}]{2,30}$", // 1
            "^[\\d]{5}$"// 2
        };
        // getter of errors list
        public List<string> Errors { get => errors; }
        // getter of patterns list
        public List<string> Patterns { get => patterns; }

        /// <summary>
        /// Used for check if the name respect conditions
        /// </summary>
        /// <param name="_nom">the name you wanna check</param>
        /// <returns>the error message</returns>
        public string CheckName( string _nom )
        {
            return Regex.IsMatch(_nom, Patterns[0]) ?  
                (Regex.IsMatch(_nom, Patterns[1]) ? "": errors[1]) 
                :errors[0];
        }

        /// <summary>
        ///  Used to check if one date respect some conditions
        /// </summary>
        /// <param name="_date">the date you wanna check</param>
        /// <returns>the error message</returns>
        public string CheckDate(string _date)
        {
            return DateTime.TryParseExact(_date,"dd/MM/yyyy",new CultureInfo("fr-FR"),DateTimeStyles.None, out DateTime _madate) ? 
                ((_madate > DateTime.Today) ? "": errors[5] )
                :errors[4];
        }
        //public string CheckDateFormat(string _date)
        //{
        //    return (int.TryParse(_date.Substring(3, 2), out int t) && t < 12) ? CheckDate(_date) : "Format date francaise uniquement";
        //}

        /// <summary>
        ///  Used to check if one sum respect some conditions
        /// </summary>
        /// <param name="_sum">the sum you wanna check</param>
        /// <returns>the error message</returns>
        public string CheckSum( string _sum ) 
        {
            return float.TryParse(_sum.Replace('.',','), out float sum) ? ((sum > 0) ? "" : errors[3]) : errors[2];        
        }

        /// <summary>
        ///  Used to check if one sum respect some conditions
        /// </summary>
        /// <param name="_sum">the sum you wanna check</param>
        /// <returns>the error message</returns>
        public string CheckCP(string _cp )
        {
            return Regex.IsMatch(_cp, Patterns[2]) ? "": errors[6] ;
        }



        
    }
}
