using System;
using Complejos;
namespace ConsolaComplejos
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Introduce la parte real ");
           // float real = float.Parse(Console.ReadLine());

            Complejo c1 = new Complejo(2, 4);
            Complejo c2 = new Complejo(4, 3);

            Complejo c3 = c1 + c2;

            Console.WriteLine("{0} + {1} = {2} ",c1,c2,c3);
            Console.ReadLine();

        }
    }
}
