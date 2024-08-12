using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("conversor de metros a pies");
            Console.Write("ingrese la cantidad a convertir: ");
            double cantidad = double.Parse(Console.ReadLine());

            double resultado = 0;

            resultado = cantidad * 3.28084;

            Console.WriteLine(cantidad + " metros son " + resultado + " pies");

            Console.ReadKey();
        }
    }
}
