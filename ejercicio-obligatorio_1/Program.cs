using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_obligatorio_1
{
    class cuenta
    {
        public double cantidad { get; set; }
        public string titular {  get; set; }
        /*public string titular
        {
            get
            {
                return Titular;
            }
            set
            {
                if (value != null)
                {
                    Titular = value;
                }
            }
        }*/
        public cuenta(string titular, double cantidad)
        {
            this.titular = titular;
            this.cantidad = cantidad;
        }

        public cuenta (string titular) 
        {
            this.titular = titular;
            //titular = "raul";
            cantidad = 0;
        }

        public void ingresar (double dineroIngresado)
        {
            if (dineroIngresado > 0)
            {
                cantidad += dineroIngresado; 
            }
            else
            {
                Console.WriteLine("ERROR, debe ingresar un numero positivo");
            }
        }

        public void retirar (double dineroSacado)
        {
            if (cantidad - dineroSacado < 0)
            {
                cantidad = 0;
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            cuenta cuenta = new cuenta("juan", 1294);
            Console.WriteLine("titular: " + cuenta.titular);
            Console.WriteLine("cantidad: " + cuenta.cantidad);

            Console.WriteLine();

            cuenta cuentaM = new cuenta("maria");
            Console.WriteLine("titular: " + cuentaM.titular);

            Console.WriteLine();

            Console.WriteLine("1. ingresar dinero");
            Console.WriteLine("2. retirar dinero");

            Console.WriteLine("* seleccione opcion *");

            int opcion;

            opcion = int.Parse(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    Console.Write("cuanto desea ingresar: ");
                    double dineroIngresado = double.Parse(Console.ReadLine());
                    cuenta.ingresar(dineroIngresado);
                    Console.WriteLine("su saldo es: $" + cuenta.cantidad);
                    break;
                case 2:
                    Console.Write("cuanto desea retirar: ");
                    double dineroSacado = double.Parse(Console.ReadLine());
                    cuenta.retirar(dineroSacado);
                    Console.WriteLine("su saldo es: $" + cuenta.cantidad);
                    break;
            }
            Console.ReadKey();
        }
    }
}