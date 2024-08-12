using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace Ejercicios_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int opcion;
            int saldo = 1000;
            do
            {
                Console.Clear();

                Console.WriteLine("cajero automático");
                Console.WriteLine("1. depositos");
                Console.WriteLine("2. retiros");
                Console.WriteLine("3. consultar saldo");
                Console.WriteLine("4. salir");

                Console.Write("seleccione una opcion: ");
                opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        Console.Write("cuanto desea depositar: ");
                        int deposito = int.Parse(Console.ReadLine());
                        saldo += deposito; // saldo = saldo + deposito
                        Console.WriteLine("su saldo actual es: $" + saldo);
                        break;
                    case 2:
                        Console.Write("cuanto desea retirar: ");
                        int retiro = int.Parse(Console.ReadLine());
                        saldo -= retiro; // saldo = saldo - retiro
                        Console.WriteLine("su saldo actual es: $" + saldo);
                        break;
                    case 3:
                        Console.WriteLine("su saldo actual es: $" + saldo);
                        break;
                }
                if (opcion != 4)
                {
                    Console.WriteLine();
                    Console.WriteLine("toque una tecla para volver al menu..");
                    Console.ReadKey();
                }

            } while (opcion != 4);
        }
    }
}