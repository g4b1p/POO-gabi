using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace Ejercicio_8
{
    class libro
    {
        public string Titulo { get; set; }
        public bool prestado { get; set; }

        public libro (string titulo)
        {
            Titulo = titulo;
            prestado = false;
        }
    }

    class bibloteca
    {
        List<libro> libros; // de tipo libro
        List<string> prestamos;
        List<string> devoluciones;

        public bibloteca ()
        {
            libros = new List<libro>
            {
                new libro("1984"),
                new libro("orgullo y prejuicio")
            };

            prestamos = new List<string>();

            devoluciones = new List<string>();
        }

        public void buscarLibro (string tituloIngresado)
        {
            libro libro = null;
            foreach (var li in libros)
            {
                if (li.Titulo == tituloIngresado)
                {
                    libro = li;
                    break;
                }
            }
            if (libro != null)
            {
                Console.WriteLine("libro encontrado: " + libro.Titulo);
            }
            else
            {
                Console.WriteLine("libro no encontrado");
            }
        }

        public void prestarLibro (string tituloIngresado)
        {
            libro libro = null;
            foreach (var li in libros)
            {
                if (li.Titulo == tituloIngresado)
                {
                    libro = li;
                    break;
                }
            }
            if (libro != null && libro.prestado == false)
            {
                libro.prestado = true;
                prestamos.Add(libro.Titulo);
                Console.WriteLine("se te ha prestado el libro: " + libro.Titulo);
            }
            else if (libro != null && libro.prestado == true)
            {
                Console.WriteLine("el libro *" + libro.Titulo + "* ya esta prestado");
            }
        }

        public void devolverLibro (string tituloIngresado)
        {
            libro libro = null;
            foreach (var li in libros)
            {
                if (li.Titulo == tituloIngresado)
                {
                    libro = li;
                    break;
                }
            }
            if (libro != null && libro.prestado == true)
            {
                libro.prestado = false;
                devoluciones.Add(libro.Titulo);
                prestamos.Remove(libro.Titulo);
                Console.WriteLine("has devuelto el libro: " + libro.Titulo);
            }
            else if (libro != null && libro.prestado == false)
            {
                Console.WriteLine("no se te ha prestado ese libro (rata no robes)");
            }
        }

        public void registros ()
        {
            Console.WriteLine("prestamos");
            if (prestamos.Count > 0)
            {
                foreach (var prestamo in prestamos)
                {
                    Console.WriteLine("* " + prestamo);
                    Console.WriteLine();
                }
            }
            else
            {
                Console.WriteLine("aun no tienes prestamos o ya haz devuelto todo..");
                Console.WriteLine();
            }

            Console.WriteLine("devoluciones");
            if (devoluciones.Count > 0)
            {
                foreach (var devolucion in devoluciones)
                {
                    Console.WriteLine("* " + devolucion);
                }
            }
            else
            {
                Console.WriteLine("aun no tienes devoluciones..");
            }
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            bibloteca bibloteca = new bibloteca();
            int opcion;
            do
            {
                Console.Clear();

                Console.WriteLine("biblioteca");
                Console.WriteLine("1. buscar libro");
                Console.WriteLine("2. prestar libro");
                Console.WriteLine("3. devolver libro");
                Console.WriteLine("4. ver registros");
                Console.WriteLine("5. salir");

                Console.WriteLine("seleccione una opcion: ");
                opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        Console.Write("ingrese título del libro buscado: ");
                        string tituloBuscado = Console.ReadLine();
                        bibloteca.buscarLibro(tituloBuscado);
                        break;
                    case 2:
                        Console.Write("ingrese título del libro prestado: ");
                        string tituloPrestado = Console.ReadLine();
                        bibloteca.prestarLibro(tituloPrestado);
                        break;
                    case 3:
                        Console.Write("ingrese título del libro a devolver: ");
                        string tituloDevuelto = Console.ReadLine();
                        bibloteca.devolverLibro(tituloDevuelto);
                        break;
                    case 4:
                        bibloteca.registros();
                        break;
                }
                if (opcion != 5)
                {
                    Console.WriteLine();
                    Console.WriteLine("toque cualquier tecla para volver al menu..");
                    Console.ReadKey();
                }

            } while (opcion != 5);
        }
    }
}