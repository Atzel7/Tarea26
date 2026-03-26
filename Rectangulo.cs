using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taller26
{
    internal class Rectangulo
    {
        private float b;
        private float h;

        public Rectangulo(float b, float h)
        {
            this.b = b;
            this.h = h;
        }

        public float CalcularArea()
        {
            return b * h;
        }
        public float CalcularPerimetro()
        {
            return 2 * (b + h);
        }
    }
}
