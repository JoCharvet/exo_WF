using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryAddi.Emprunt
{
    static class ValidEmprunt
    {
        public static string  SupNb(double nb)
        {
            return (nb > 0) ? "Kewl !" : "Nope";
        }

        
    }
}
