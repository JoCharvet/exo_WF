using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace BiblioReprise.Valid
{
    public class Validation
    {
        public string CheckDate(string _date)
        {
            return DateTime.TryParseExact(_date, "dd/MM/yyyy", new CultureInfo("fr-FR"), DateTimeStyles.None, out DateTime _madate) ?
                ((_madate > DateTime.Today) ? "" : "ne doit pas être antérieur à la date du jour")
                : "La date doit être valide (JJ/MM/AAAA)";
        }

        public string CheckName(string _nom)
        {
            return Regex.IsMatch(_nom, "^[\\p{L}]{2,}(?:[-]{0,1}[\\p{L}]{2,}){0,1}$") ?
                (Regex.IsMatch(_nom, "^[\\p{L}]{2,30}$") ? "" : "doit comprendre en 2 et 30 charactères")
                : "seul les lettres et le - sont authorisé";
        }
        public string CheckCP(string _cp)
        {
            return Regex.IsMatch(_cp, "^[\\d]{5}$") ? "" : "Seulement 5 nombres";
        }
    }
}
