using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taller2D
{
    internal class Triangulo
    {
        private float h;
        private float b;

        public Triangulo(float h, float b)
        {
            this.b = b;
            this.h = h;
        }
        public Triangulo (string b, string h)
        {
            this.b=float.Parse(b);
            this.h=float.Parse(h);
        }

        public float Area() => b * h / 2;
    }
}
