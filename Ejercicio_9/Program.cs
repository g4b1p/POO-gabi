using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace Ejercicio_9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ingrese la coordenada X del 1° punto: ");
            double X1 = int.Parse(Console.ReadLine());

            Console.WriteLine("ingrese la coordenada Y del 1° punto: ");
            double Y1 = int.Parse(Console.ReadLine());

            Console.WriteLine("ingrese la coordenada X del 2° punto: ");
            double X2 = int.Parse(Console.ReadLine());

            Console.WriteLine("ingrese la coordenada Y del 2° punto: ");
            double Y2 = int.Parse(Console.ReadLine());

            // Math.Sqrt() : calcula la raiz cuadrada
            // Math.Pow() : caulcula la potencia asignada
            double distancia = Math.Sqrt(Math.Pow(X2 - X1, 2) + Math.Pow(Y2 - Y1, 2));

            Console.WriteLine("la distancia es: " + distancia);

            Console.ReadKey();
        }
    }
}