using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Menu
{
    class Menu
    {
        public string nombreMenu;
        public string[] opciones;
        public int fila;
        public int columna;
        public int opcionSeleccionada;

        public Menu(int opcionSeleccionada, string nombreMenu, string[] opciones, int fila, int columna)
        {
            this.opcionSeleccionada = opcionSeleccionada;
            this.nombreMenu = nombreMenu;
            this.opciones = opciones;
            this.fila = fila;
            this.columna = columna;
        }
    }

    class MenuPrincipal
    {
        public List<Menu> menu = new List<Menu>();
        int menuSeleccionado = 0;

        public MenuPrincipal(Dictionary<string, string[]> menus) // usa diccionario (coleccion de pares clave-valor) para crear instancias de la clase Menu y añadirlas a la lista menu
        {
            // posiciones inicial
            int fila = 1;
            int columna = 1;

            foreach (var subMenu in menus)
            {
                menu.Add(new Menu(0, subMenu.Key, subMenu.Value, fila, columna)); // añade en la lista menu, determinada instancia de Menu
                columna += subMenu.Key.Length + 2; // = col = col + (subMenu.Key.Length + 2) --> para añadir un espaciado entre los nombres de Menu
            }
        }

        public void dibujar()
        {
            Console.Clear(); // para q desaparezca el menu anterior
            foreach (var m in menu) // itera sobre cada menu(m) en la lista menu
            {
                Console.SetCursorPosition(m.columna, m.fila);
                if (m == menu[menuSeleccionado]) // para menu seleccionado
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.BackgroundColor = ConsoleColor.Blue;
                    Console.WriteLine(m.nombreMenu);

                    for (int i = 0; i < m.opciones.Length; i++)
                    {
                        Console.SetCursorPosition(m.columna, m.fila + i + 1); // el 1 es para evitar chocar con el nombre del menu
                        if (i == m.opcionSeleccionada) // para opcion seleccionado
                        {
                            Console.BackgroundColor = ConsoleColor.Blue;
                            Console.ForegroundColor = ConsoleColor.White;
                        }
                        else
                        {
                            Console.BackgroundColor = ConsoleColor.Black;
                            Console.ForegroundColor = ConsoleColor.Gray;
                        }
                        Console.WriteLine(m.opciones[i]); // imprime la opción del menu de la posición i de opciones
                    }
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.WriteLine(m.nombreMenu);
                }
            }
            Console.ResetColor();
        }

        public void arriba()
        {
            menu[menuSeleccionado].opcionSeleccionada--; // de 0 a -x
            if (menu[menuSeleccionado].opcionSeleccionada < 0)
                menu[menuSeleccionado].opcionSeleccionada = menu[menuSeleccionado].opciones.Length - 1;
            dibujar();
        }

        public void abajo()
        {
            menu[menuSeleccionado].opcionSeleccionada++; // de 0 a +x
            if (menu[menuSeleccionado].opcionSeleccionada >= menu[menuSeleccionado].opciones.Length)
                menu[menuSeleccionado].opcionSeleccionada = 0;
            dibujar();
        }

        public void izq()
        {
            menuSeleccionado--; // de 0 a -y
            if (menuSeleccionado < 0)
                menuSeleccionado = menu.Count - 1;
            dibujar();
        }

        public void der()
        {
            menuSeleccionado++; // de 0 a +y
            if (menuSeleccionado >= menu.Count)
                menuSeleccionado = 0;
            dibujar();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var menus = new Dictionary<string, string[]>
            {
                { "Archivo", new string[] { "Nuevo Cliente", "Modificar Cliente", "Listar Clientes", "Salir" } },
                { "Editar", new string[] { "Nuevo Producto", "Modificar Producto", "Eliminar Producto", "Listar Producto", "Salir" } }
            };

            MenuPrincipal menuPrincipal = new MenuPrincipal(menus);
            menuPrincipal.dibujar();

            while (true)
            {
                var key = Console.ReadKey(true).Key;

                switch (key)
                {
                    case ConsoleKey.UpArrow:
                        menuPrincipal.arriba();
                        break;

                    case ConsoleKey.DownArrow:
                        menuPrincipal.abajo();
                        break;

                    case ConsoleKey.LeftArrow:
                        menuPrincipal.izq();
                        break;

                    case ConsoleKey.RightArrow:
                        menuPrincipal.der();
                        break;
                }
            }
        }
    }
}