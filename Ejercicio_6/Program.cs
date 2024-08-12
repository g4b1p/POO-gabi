using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace Ejercicio_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ingrese cuantas tareas quiere listar: ");
            int limiteTareas = int.Parse(Console.ReadLine());
            List<string> listadeTareas = new List<string>();

            for (int i = 1; i <= limiteTareas; i++)
            {
                Console.WriteLine("ingrese la " + i + "° tarea: ");
                string tarea = Console.ReadLine();
                listadeTareas.Add(tarea);
            }

            Console.WriteLine();
            Console.WriteLine("tu lista de tareas");
            /*for (int j = 1; j <= limiteTareas; j++)
            {
                Console.Write(j + "° tarea: ");
                foreach (string tarea in listadeTareas)
                {

                    Console.WriteLine(tarea);
                }
            }*/
            for (int j = 0; j < listadeTareas.Count; j++) // Count: toma el numero de elementos contenidos en la lista
            {
                Console.WriteLine((j + 1) + "° tarea: " + listadeTareas[j]);
            }

            Console.ReadKey();
        }
    }
}