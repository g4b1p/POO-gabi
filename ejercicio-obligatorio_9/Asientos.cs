using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace ejercicio_obligatorio_9
{
    internal class Asientos
    {
        public char columna;
        public int fila;
        public bool ocupado;
        public Espectadores ocupante;

        public Asientos(int fila, char columna)
        {
            this.fila = fila;
            this.columna = columna;
            this.ocupado = false;
        }

        public void ocupar(Espectadores espectador)
        {
            ocupado = true;
            ocupante = espectador;
        }
    }
}
