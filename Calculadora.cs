using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taller26
{
    internal class Calculadora
    {
        public int Operar(int n1, int n2, string op)
        {
            if (op == "+") return n1 + n2;
            else if (op == "-") return n1 - n2;
            else if (op == "*") return n1 * n2;
            else if (op == "/")
            {
                if (n2 != 0) return n1 / n2;
                else return 0;
            }
            else if (op == "%") return n1 % n2;
            else return 0;
        }
    }    
}
