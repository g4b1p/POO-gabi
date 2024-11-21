using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_obligatorio_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Electrodoméstico[] electrodomesticos = new Electrodoméstico[10];

            electrodomesticos[0] = new Electrodoméstico(150, "rojo", 'A', 25);
            electrodomesticos[1] = new Lavadora(200, "blanco", 'B', 40, 35);
            electrodomesticos[2] = new Televisión(300, "negro", 'C', 30, 50, true);
            electrodomesticos[3] = new Electrodoméstico();
            electrodomesticos[4] = new Lavadora(180, 45);
            electrodomesticos[5] = new Televisión(400, 55);
            electrodomesticos[6] = new Electrodoméstico(100, "gris", 'E', 10);
            electrodomesticos[7] = new Lavadora(250, "azul", 'A', 60, 28);
            electrodomesticos[8] = new Televisión(350, "rojo", 'B', 45, 42, false);
            electrodomesticos[9] = new Electrodoméstico(120, "negro", 'D', 15);

            double totalElectrodomesticos = 0;
            double totalLavadoras = 0;
            double totalTelevisores = 0;

            foreach (Electrodoméstico e in electrodomesticos)
            {
                //double precio.precioFinal();
                double precio = e.precioFinal();

                totalElectrodomesticos += precio;

                if (e is Lavadora)
                {
                    totalLavadoras += precio;
                }
                else if (e is Televisión)
                {
                    totalTelevisores += precio;
                }
            }

            Console.WriteLine("total electrodomesticos: " + totalElectrodomesticos);
            Console.WriteLine("total lavadoras: " + totalLavadoras);
            Console.WriteLine("total televisores: " + totalTelevisores);

            Console.ReadKey();
        }
    }
}
