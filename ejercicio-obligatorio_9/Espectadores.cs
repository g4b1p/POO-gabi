using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace ejercicio_obligatorio_9
{
    internal class Espectadores
    {
        public string nombre;
        public int edad;
        public int dinero;

        public Espectadores(string nombre, int edad, int dinero)
        {
            this.nombre = nombre;
            this.edad = edad;
            this.dinero = dinero;
        }
    }
}
