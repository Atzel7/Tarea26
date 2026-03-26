using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taller26
{
    internal class Año
    {
        private int año;
        public bool EsBisiesto(int año)
        {
           return(año % 4 == 0 && año % 100 != 0) || (año % 400 == 0);
        }

    }
}
