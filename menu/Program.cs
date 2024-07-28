using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace menu
{
    class menu
    {
        string[] opciones;
        int OpcionSeleccionada;

        public menu(string[] opciones)
        {
            this.opciones = opciones;
            OpcionSeleccionada = 0;
        }

        public void dibujar(int fila, int columna)
        {
            foreach (string opcion in opciones)
            {
                Console.SetCursorPosition(columna, fila);
                if (opcion == opciones[OpcionSeleccionada])
                {
                    Console.BackgroundColor = ConsoleColor.Green;
                    Console.ForegroundColor = ConsoleColor.Black;
                }
                else
                {
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.ForegroundColor = ConsoleColor.White;
                }
                Console.WriteLine(opcion);
                fila++;
            }
        }

        public void arriba()
        {
            OpcionSeleccionada--;
            if (OpcionSeleccionada < 0)
            {
                OpcionSeleccionada = opciones.Length - 1;
            }
        }

        public void abajo()
        {
            OpcionSeleccionada++;
            if (OpcionSeleccionada >= opciones.Length)
            {
                OpcionSeleccionada = 0;
            }
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            string[] opciones = { "nuevo", "abrir", "eliminar", "crear" };
            menu Menu = new menu(opciones);
            ConsoleKeyInfo tecla;

            do
            {
                Menu.dibujar(5, 10);
                tecla = Console.ReadKey();

                switch (tecla.Key)
                {
                    case ConsoleKey.UpArrow:
                        Menu.arriba();
                        break;
                    case ConsoleKey.DownArrow:
                        Menu.abajo();
                        break;
                }
            } while (true);

        }
    }
}