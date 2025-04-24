using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taller2D
{
    internal class Listas
    {
        public void Start()
        {
            /* Triangulo t1 = new Triangulo(3, 5);
             Triangulo t2 = new Triangulo(4, 9);

             Triangulo[] tris = { t1, t2, new Triangulo(2, 3) };
             tris[3] = new Triangulo(5,7);

             List<Triangulo> lista = new List<Triangulo>();
             lista.Add(t1);
             lista.Add(t2);
             lista.Add(new Triangulo(4, 2));



             Console.WriteLine(lista.Count);

             foreach (Triangulo tr in lista)
             { 
                 Console.WriteLine(tr.Area());
             }*/

            Alumnos a1 = new Alumnos(13, 15, 16);
            Alumnos a2 = new Alumnos(18, 17, 19);

            List<Alumnos> lista = new List<Alumnos>();
            lista.Add(a1);
            lista.Add(a2);
            for (int i = 0; i < 10; i++)
            {
              Console.WriteLine(lista[i]);
            }
        }
    }
}
