using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEMANA1_C_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ejer1();
            ejer2();
            Console.ReadKey();



        }
        static void ejer1()
        {
            string nombre, carrera;
            Console.WriteLine("ingrese su nombre: ");
            nombre = Console.ReadLine();
            Console.WriteLine("ingrese su carrera: ");
            carrera = Console.ReadLine();
            Console.WriteLine($"{nombre} bienvenido al FA de {carrera}");

        }
        static void ejer2()
        {
            Console.WriteLine("\"luis\"");
        }
    }
}
