using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace ejercicio_obligatorio_9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Peliculas peli = new Peliculas("terrifier 3", 2.17, 18, "damien leone");

            Cine cine = new Cine(peli, 5000);

            //Espectadores espectador = new Espectadores("raul", 24, 6000);

            Random random = new Random();
            List<Espectadores> espectadores = new List<Espectadores>();
            for (int i = 0; i < 15; i++)
            {
                espectadores.Add(new Espectadores(
                    "espectador " + (i + 1),
                    random.Next(15, 30),
                    random.Next(5000, 10000)
                ));
            }

            foreach (var espectador in espectadores)
            {
                cine.sentarEspectador(espectador);
            }

            cine.mostrarAsientos();

            Console.ReadKey();
        }
    }
}