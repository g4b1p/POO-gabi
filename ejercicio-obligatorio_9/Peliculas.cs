using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace ejercicio_obligatorio_9
{
    internal class Peliculas
    {
        public string titulo;
        public double duracion;
        public int edadMin;
        public string director;

        public Peliculas(string titulo, double duracion, int edadMin, string director)
        {
            this.titulo = titulo;
            this.duracion = duracion;
            this.edadMin = edadMin;
            this.director = director;
        }
    }
}
