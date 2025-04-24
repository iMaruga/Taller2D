using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taller2D
{
    internal class Circulo
    {
        private float r;

        public Circulo(float r) 
        {
            this.r = r;
        }
        public float Area()
        {
            return 3.14f * r * r;
        }
    }
}
