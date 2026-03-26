using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taller26
{
    internal class Triangulo
    {
        private float b;
        private float h;

        public Triangulo(float b, float h)
        {
            this.b = b;
            this.h = h;
        }

        public float CalcularArea()
        {
            return (b * h) / 2;
        }
    }
}
