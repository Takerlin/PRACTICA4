using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace paroimpar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Variables
            byte numero;
            Console.Write("Dame un numero y te dire si es par o impar");
            numero = Convert.ToByte(Console.ReadLine());
            if (numero %2 == 0)
            {
                Console.WriteLine("El numero es par");
                Console.ReadKey();

            }
            else
            {
                Console.WriteLine("el numero es impar");
                Console.ReadKey();
            }
        }
    }
}
