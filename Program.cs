using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taller2D
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cuadrado c = new Cuadrado(5,7);

            Circulo o = new Circulo(2);

            Console.WriteLine("cuadrado = " + c.Area());
            Console.WriteLine("circulo = " + o.Area());
            Console.ReadLine();
        }
    }
}
