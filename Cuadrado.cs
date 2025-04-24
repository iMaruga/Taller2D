using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taller2D
{
    internal class Cuadrado
    {
        private float b;
        private float h;
        public Cuadrado(float h, float b) 
        {
            this.b = b;
            this.h = h;
        }

        public float Area()
        { 
            return b * h;
        }
    }
}
