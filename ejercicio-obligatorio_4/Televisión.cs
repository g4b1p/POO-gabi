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

        private int _resolucion = 20;
        private bool _sintonizadorTDT = false;

        public Televisión() : base()
        {
            resolucion = _resolucion;
            sintonizadorTDT = _sintonizadorTDT;
        }

        public Televisión(double precioBase, double peso) : base(precioBase, peso)
        {
            resolucion = _resolucion;
            sintonizadorTDT = _sintonizadorTDT;
        }

        public Televisión(double precioBase, colores color, letrasConsumo consumoEnergetico, double peso, int resolucion, bool sintonizadorTDT) : base(precioBase, color, consumoEnergetico, peso)
        {
            this.resolucion = _resolucion;
            this.sintonizadorTDT = _sintonizadorTDT;
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
            double nuevoPrecio = base.precioFinal();

            if (resolucion > 40)
            {
                //nuevoPrecio = nuevoPrecio * (1 + 30 / 100);
                nuevoPrecio = nuevoPrecio * 1.30;
            }

            if (sintonizadorTDT == true)
            {
                nuevoPrecio += 50;
            }
            return nuevoPrecio;
        }
    }
}
