using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace PRACTICA4
// Hacer un programa que le pida al usuario un número
// del 1 al 12 y escriba el nombre del mes que
// Corresponde ese número en el calendario.Agregar switch case.//

{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Variables
            byte calendario;
           

            // preguntar de 1 al 12 el mes
            Console.WriteLine(" De los numero del 1-12 ¿Que mes deseas consultar?");
            
            // Pedimos al usuario que escoja una opción
            calendario = Convert.ToByte(Console.ReadLine());


            switch (calendario)
            {
                case 1:
                    Console.WriteLine(" El #1 corresponde al mes de ENERO");
                    Console.ReadKey();
                    break;
                case 2:
                    Console.WriteLine(" El #2 corresponde al mes de FEBRERO");
                    Console.ReadKey();
                    break;
                case 3:
                    Console.WriteLine(" El #3 corresponde al mes de MARZO");
                    Console.ReadKey();
                    break;
                case 4:
                    Console.WriteLine(" El #4 corresponde al mes de ABRIL");
                        Console.ReadKey();
                    break;
                case 5:
                    Console.WriteLine(" El #5 corresponde al mes de MAYO");
                    Console.ReadKey();
                    break;
                case 6:
                    Console.WriteLine(" El #6 corresponde al mes de JUNIO");
                    Console.ReadKey();
                    break;
                case 7:
                    Console.WriteLine(" El #7 corresponde al mes de JULIO");
                    Console.ReadKey();
                    break;
                case 8:
                    Console.WriteLine(" El #8 corresponde al mes de AGOSTO");
                    Console.ReadKey();
                    break;
                case 9:
                    Console.WriteLine(" El #9 corresponde al mes de SEPTIEMBRE");
                    Console.ReadKey();
                    break;
                case 10:
                    Console.WriteLine(" El #10 corresponde al mes de OCTUBRE");
                    Console.ReadKey();
                    break;
                case 11:
                    Console.WriteLine(" El #11 corresponde al mes de NOVIEMBRE");
                    Console.ReadKey();
                    break;
                case 12:
                    Console.WriteLine(" El #12 corresponde al mes de DICIEMBRE");
                    Console.ReadKey();
                    break;
                default:
                    Console.WriteLine("Ingresa una opción valida, te dije que nomas del 1 al 12");
                    Console.ReadKey();

                    break;
            }
           

        }
    }
}
        