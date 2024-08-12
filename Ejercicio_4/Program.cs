using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace Ejercicio_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ingrese el limite de numeros: ");
            int limiteNum = int.Parse(Console.ReadLine());
            List<int> listadeNums = new List<int>();

            for (int i = 1; i <= limiteNum; i++) 
            {
                listadeNums.Add(i);
            }

            Console.WriteLine("los numeros ingresados son: ");
            foreach (var numero in listadeNums)
            {
                Console.Write(numero + " ");
            }

            Console.ReadKey();
        }
    }
}