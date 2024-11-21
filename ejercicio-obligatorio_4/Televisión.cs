using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_obligatorio_4
{
    internal class Televisión : Electrodoméstico
    {
        private int resolucion;
        private bool sintonizadorTDT;

        public Televisión() : base()
        {
            this.resolucion = 20;
            this.sintonizadorTDT = false;
        }

        public Televisión(double precioBase, double peso) : base(precioBase, peso)
        {
            this.resolucion = 20;
            this.sintonizadorTDT = false;
        }

        public Televisión(double precioBase, string color, char consumoEnergetico, double peso, int resolucion, bool sintonizadorTDT) : base(precioBase, color, consumoEnergetico, peso)
        {
            this.resolucion = resolucion;
            this.sintonizadorTDT = sintonizadorTDT;
        }

        public int gResolucion()
        {
            return resolucion;
        }

        public bool gSintonizadorTDT()
        {
            return sintonizadorTDT;
        }

        public override double precioFinal()
        {
            double precio = base.precioFinal();

            if (resolucion > 40)
            {
                precio *= 1.30;
            }

            if (sintonizadorTDT)
            {
                precio += 50;
            }
            return precio;
        }
    }
}
