using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace Ejercicio_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("adivina el numero");
            Random random = new Random();
            int numRandom = random.Next(1, 100);
            int intentos = 0;
            int numIntento;

            do
            {
                Console.Write("numero intento: ");
                numIntento = int.Parse(Console.ReadLine());

                if (numIntento > numRandom)
                {
                    Console.WriteLine("muy grande, otra vez..");
                    intentos++;
                }
                else if (numIntento < numRandom)
                {
                    Console.WriteLine("muy chico, otra vez..");
                    intentos++;
                }

                else
                {
                    Console.WriteLine("CORRECTO! el numero era " + numRandom);
                    Console.WriteLine("ganaste con " + intentos + " intentos");
                }

            } while (numRandom != numIntento);
            Console.ReadKey();
        }
    }
}