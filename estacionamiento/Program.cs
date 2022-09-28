using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace estacionamiento

//Hacer un programa que le diga al usuario el precio que debe pagar por el servicio
//de estacionamiento de un centro comercial con base en el tiempo que ha permanecido ahí,
//los primeros 60 minutos: $5.00, las primeras 2 horas $15.00 y de 2 horas en adelante: $40.00
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int hora;
            Console.WriteLine("ESTACIONAMIENTO *CENTRO COMERCIAL AYOLA* donde no nos hacemos responsables de tus objetos perdidos, ¿Cuanto tiempo duraste dentro? ingresar el tiempo en minutos porfavor");
            hora = Convert.ToInt32(Console.ReadLine());

            if (hora <=60)
            {
                Console.WriteLine("El monto a pagar es de $5.00");
                Console.ReadKey();

            }
            if (hora >=61 && hora <=120)
            {
                Console.WriteLine("El monto a pagar es de $15.00");
                Console.ReadKey();

            }
            if (hora >121)
            {
                Console.WriteLine("El monto a pagar es de $40.00");
                Console.ReadKey();
            }


        }
    }
}
