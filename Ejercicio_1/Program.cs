using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace Ejercicios_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ingrese cuantos numeros quiere calcular: ");
            int CantNums = int.Parse(Console.ReadLine());
            List<int> numeros = new List<int>();
            for (int i = 1; i <= CantNums; i++)
            {
                Console.WriteLine("ingrese " + i + "° numero: ");
                int numero = int.Parse(Console.ReadLine());
                numeros.Add(numero);
            }

            // promedio
            double suma = numeros.Sum();
            double promedio = suma / CantNums;
            Console.WriteLine("el promedio es: " + promedio);

            Console.ReadKey();
        }
    }
}