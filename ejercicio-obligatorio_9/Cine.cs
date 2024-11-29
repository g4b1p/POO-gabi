using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace ejercicio_obligatorio_9
{
    internal class Cine
    {
        public Peliculas película;
        public int precioEntrada;

        private List<Asientos> asientos = new List<Asientos>();

        public Cine(Peliculas peliculas, int precioEntrada)
        {
            this.película = peliculas;
            this.precioEntrada = precioEntrada;
            crearAsientos();
        }

        public void crearAsientos()
        {
            Console.WriteLine();

            for (int fila = 8; fila >= 1; fila--)
            {
                for (char columna = 'A'; columna <= 'I'; columna++)
                {
                    asientos.Add(new Asientos(fila, columna));
                }
            }
        }

        public void sentarEspectador(Espectadores espectador)
        {
            if (espectador.edad < película.edadMin)
            {
                Console.WriteLine(espectador.nombre + " no tiene la edad suficiente para ver la peli");
                return;
            }

            if (espectador.dinero < precioEntrada)
            {
                Console.WriteLine(espectador.nombre + " no tiene suficiente dinero para la entrada");
                return;
            }

            foreach (var a in asientos)
            {
                var asientoDisponible = a.ocupado;
                if (asientoDisponible == false)
                {
                    a.ocupar(espectador);
                    Console.WriteLine(espectador.nombre + " se sento en el asiento " + a.fila + a.columna);
                    return;
                }
            }
            Console.WriteLine("no hay asiento para " + espectador.nombre);
        }

        public void mostrarAsientos()
        {
            Console.WriteLine("asientos:");

            for (int fila = 8; fila >= 1; fila--)
            {
                for (char columna = 'A'; columna <= 'I'; columna++)
                {
                    Asientos asiento = null;
                    foreach (var a in asientos)
                    {
                        if (a.fila == fila && a.columna == columna)
                        {
                            asiento = a;
                            break;
                        }
                    }

                    if (asiento != null)
                    {
                        Console.Write(asiento.ocupado ? "X " : $"{asiento.fila}{asiento.columna} ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
