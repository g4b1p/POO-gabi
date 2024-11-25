using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_obligatorio_6
{
    class Libro
    {
        private int ISBN;
        private string titulo;
        private string autor;
        private int numPaginas;

        public Libro(int ISBN, string titulo, string autor, int numPaginas)
        {
            this.ISBN = ISBN;
            this.titulo = titulo;
            this.autor = autor;
            this.numPaginas = numPaginas;
        }

        #region sets

        public void sISBN (int ISBN)
        {
            this.ISBN = ISBN;
        }

        public void sTitulo(string titulo)
        {
            this.titulo = titulo;
        }

        public void sAutor(string autor)
        {
            this.autor = autor;
        }

        public void sNumPaginas(int numPaginas)
        {
            this.numPaginas = numPaginas;
        }

        #endregion

        #region gets

        public int gISBN()
        {
            return ISBN;
        }

        public string gTitulo()
        {
            return titulo;
        }

        public string gAutor()
        {
            return autor;
        }

        public int gNumPaginas()
        {
            return numPaginas;
        }

        #endregion

        public void mostrarInfo()
        {
            Console.WriteLine("el libro con ISBN " + ISBN + " creado por " + autor + " tiene " + numPaginas + " paginas");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Libro libro1 = new Libro(978981592, "heist", "ariana godoy", 245);
            Libro libro2 = new Libro(978808236, "mujercitas", "louisa may alcott", 688);

            libro1.mostrarInfo();
            libro2.mostrarInfo();

            if (libro1.gNumPaginas() > libro2.gNumPaginas())
            {
                Console.WriteLine("el libro con mas paginas es: " + libro1.gTitulo());
            }
            else
            {
                Console.WriteLine("el libro con mas paginas es: " + libro2.gTitulo());
            }

            Console.ReadKey();
        }
    }
}
