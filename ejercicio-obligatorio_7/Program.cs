using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_obligatorio_7
{
    class Raíces
    {
        private int a;
        private int b;
        private int c;

        public Raíces (int a, int b, int c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }

        public void obtenerRaices()
        {
            //double resultado = (-b±√((b ^ 2) - (4 * a * c)))/ (2 * a);

            double solucion1 = (-b + Math.Sqrt(Math.Pow(b, 2) - (4 * a * c))) / (2 * a);
            double solucion2 = (-b - Math.Sqrt(Math.Pow(b, 2) - (4 * a * c))) / (2 * a);

            Console.WriteLine("1° solucion: " + solucion1);
            Console.WriteLine("2° solucion: " + solucion2);
        }

        public void obtenerRaiz()
        {
            double solucion = (- b) / (2 * a);

            Console.WriteLine("unica solucion: " + solucion);
        }

        public double getDiscriminante()
        {
            double discriminante = Math.Pow(b, 2) - (4 * a * c);

            return discriminante;
        }

        public bool tieneRaices()
        {
            if (getDiscriminante() >= 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool tieneRaiz()
        {
            if (getDiscriminante() == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void calcular()
        {
            if (tieneRaices() == true)
            {
                obtenerRaices();
            }
            else if (tieneRaiz() == false)
            {
                obtenerRaiz();
            }
            else
            {
                Console.WriteLine("no tiene solucion");
            }
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Raíces p = new Raíces(4, 9, 2);
            p.calcular();

            Console.WriteLine();

            Raíces q = new Raíces(14, 39, 62);
            q.calcular();

            Console.ReadKey();
        }
    }
}
