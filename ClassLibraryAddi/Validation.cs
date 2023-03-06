using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ClassLibraryAddi
{
    internal class Validation
    {
        private List<string> errors = new List<string>{  "Ne doit contenir que des lettres.", // 0
            "Ne doit pas dépasser 30 cactères." // 1
            ,"Ne doit contenir que des chiffre.", // 2
        "Le nombre de peut pas être négatif", // 3 
        "la date doit être valide", // 4
        "la date doit être supérieur à la date du jour", // 5
        "pas plus de 5 caractère numérique"}; // 6

        private List<Regex> regexes = new List<Regex> { new Regex(@"^[\p{L}]$"), //0
            new Regex(@"^[.]{2,30}$"), // 1
            new Regex(@"^[\d]+$"),// 2
            new Regex(@"^[\d]+$"), // 3
        };

        public List<string> Errors { get => errors; }

        public string VerifNom( string _nom )
        {
           
        }
        
    }
}
