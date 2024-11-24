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

            electrodomesticos[0] = new Electrodoméstico(300, Electrodoméstico.colores.rojo, Electrodoméstico.letrasConsumo.C, 30);
            electrodomesticos[1] = new Electrodoméstico(800, Electrodoméstico.colores.negro, Electrodoméstico.letrasConsumo.D, 150);
            electrodomesticos[2] = new Electrodoméstico(900, Electrodoméstico.colores.azul, Electrodoméstico.letrasConsumo.F, 90);
            electrodomesticos[3] = new Electrodoméstico(100, Electrodoméstico.colores.gris, Electrodoméstico.letrasConsumo.A, 15);

            electrodomesticos[4] = new Lavadora(200, Electrodoméstico.colores.negro, Electrodoméstico.letrasConsumo.D, 70, 20);
            electrodomesticos[5] = new Lavadora(700, Electrodoméstico.colores.rojo, Electrodoméstico.letrasConsumo.A, 60, 30);
            electrodomesticos[6] = new Lavadora(500, Electrodoméstico.colores.azul, Electrodoméstico.letrasConsumo.C, 80, 50);

            electrodomesticos[7] = new Televisión(400, Electrodoméstico.colores.gris, Electrodoméstico.letrasConsumo.E, 50, 10, true);
            electrodomesticos[8] = new Televisión(600, Electrodoméstico.colores.azul, Electrodoméstico.letrasConsumo.F, 10, 70, true);
            electrodomesticos[9] = new Televisión(1000, Electrodoméstico.colores.gris, Electrodoméstico.letrasConsumo.C, 90, 40, false);

            double totalElectrodomesticos = 0;
            double totalLavadoras = 0;
            double totalTelevisores = 0;

            foreach (Electrodoméstico e in electrodomesticos)
            {
                double nuevoPrecio = e.precioFinal();

                totalElectrodomesticos += nuevoPrecio;

                if (e is Lavadora)
                {
                    totalLavadoras += nuevoPrecio;
                }
                else if (e is Televisión)
                {
                    totalTelevisores += nuevoPrecio;
                }
            }

            Console.WriteLine("total electrodomesticos: " + totalElectrodomesticos);
            Console.WriteLine("total lavadoras: " + totalLavadoras);
            Console.WriteLine("total televisores: " + totalTelevisores);

            totalElectrodomesticos += totalLavadoras + totalTelevisores;

            Console.WriteLine();
            Console.WriteLine("total electrodomesticos más lavadoras y televisores: " + totalElectrodomesticos);

            Console.ReadKey();
        }
    }
}
