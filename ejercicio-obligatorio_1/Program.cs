using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_obligatorio_1
{
    class cuenta
    {
        public string titular { get; set; }
        public double cantidad { get; set; }

        public cuenta(string titular, double cantidad)
        {
            this.titular = titular;
            this.cantidad = cantidad;
        }

        public cuenta (string titular)
        {
            this.titular = titular;
        }

        public void ingresar (double dineroIngresado)
        {
            if (dineroIngresado > 0)
            {
                cantidad += dineroIngresado; 
            }
            else
            {
                Console.WriteLine("debe ingresar un numero positivo");
            }
        }

        public void retirar (double dineroSacado)
        {
            if (cantidad - dineroSacado < 0)
            {
                cantidad = 0;
            }
            else
            {
                cantidad -= dineroSacado;
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            cuenta cuenta1 = new cuenta("raul", 1000);
            cuenta1.ingresar(500);
            cuenta1.retirar(100);
            Console.WriteLine("titular: " + cuenta1.titular + ", cantidad: " + cuenta1.cantidad);

            Console.WriteLine();

            cuenta cuenta2 = new cuenta("rocio");
            cuenta2.ingresar(500);
            cuenta2.retirar(200);
            Console.WriteLine("titular: " + cuenta2.titular + ", cantidad: " + cuenta2.cantidad);

            Console.ReadKey();
        }
    }
}