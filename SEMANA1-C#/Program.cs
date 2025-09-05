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
            
            ejer3();
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
        static void ejer3()
        {
            Console.Write("ingrese num 1: ");
            int x = int.Parse(Console.ReadLine());
            Console.Write("ingrese num 2: ");
            int y = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nsuma: " + (x + y));
            Console.WriteLine("resta: " + (x - y));
            Console.WriteLine("multiplicacion: " + (x * y));
            Console.WriteLine("division: " + (x / y));


        }
    }
}
