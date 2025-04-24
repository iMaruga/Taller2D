using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taller2D
{
    internal class Alumnos
    {
        private string alumnonombre;

        private float prom1;
        private float prom2;
        private float prom3;

        public Alumnos(string alumnonombre, float prom1, float prom2, float prom3)
        {
            this.alumnonombre = alumnonombre;
            this.prom1 = prom1;
            this.prom2 = prom2;
            this.prom3 = prom3;
        }

        public string Nombre() => alumnonombre;
        public float PromedioFinal() => (prom1+prom2 + prom3*2)/4 ;
        public string Display() => $"{Nombre()}: {PromedioFinal()}";
    }
}
