using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_obligatorio_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Serie[] series = new Serie[5];
            Videojuego[] videojuegos = new Videojuego[5];

            series[0] = new Serie("cromañon", 1, "tragedia", "Josefina Licitra");
            series[1] = new Serie("heartstopper", 3, "romance", "Alice Oseman");
            series[2] = new Serie("juego del calamar", 1, "accion", "Hwang Dong-hyuk");
            series[3] = new Serie("estamos muertos", 1, "drama", "Chun Sung-il");
            series[4] = new Serie("modern family", 11, "comedia", "Christopher Lloyd");

            videojuegos[0] = new Videojuego("Counter-Strike", 5, "disparos táctico", "Valve Software");
            videojuegos[1] = new Videojuego("valorant", 4, "disparos táctico", "Riot Games");
            videojuegos[2] = new Videojuego("roblox", 3, "simulaciones", "Roblox Corporation");
            videojuegos[3] = new Videojuego("fornite", 2, "Battle royale", "Epic Games");
            videojuegos[4] = new Videojuego("league of legends", 1, "rol de acción", "Riot Games");

            series[1].entregar();
            series[3].entregar();
            videojuegos[0].entregar();
            videojuegos[2].entregar();


            int cantSeriesEntregadas = 0;
            foreach (Serie s in series)
            {
                if (s.isEntregado() == true)
                {
                    cantSeriesEntregadas++;
                }
            }
            Console.WriteLine("cantidad de series entregadas: " + cantSeriesEntregadas);


            int cantVideojuegosEntregados = 0;
            foreach (Videojuego v in videojuegos)
            {
                if (v.isEntregado() == true)
                {
                    cantVideojuegosEntregados++;
                }
            }
            Console.WriteLine("cantidad de videojuegos entregados: " + cantVideojuegosEntregados);


            Videojuego videojuegoMasHoras = videojuegos[0];
            foreach (Videojuego j in videojuegos)
            {
                if (videojuegoMasHoras.compareTo(j) < 0)
                    videojuegoMasHoras = j;
            }
            Console.WriteLine("el videojuego con mas horas es: " + videojuegoMasHoras.gTitulo());


            Serie serieMasTemporadas = series[0];
            foreach (Serie s in series)
            {
                if (serieMasTemporadas.compareTo(s) < 0)
                    serieMasTemporadas = s;
            }
            Console.WriteLine("la serie con mas temporadas es: " + serieMasTemporadas.gTitulo());


            Console.ReadKey();
        }
    }
}
