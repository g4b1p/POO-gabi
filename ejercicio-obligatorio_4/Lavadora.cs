using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_obligatorio_4
{
    internal class Lavadora : Electrodoméstico
    {
        private int carga;

        private int _carga = 5;

        public Lavadora() : base()
        {
            carga = _carga;
        }

        public Lavadora(double precioBase, double peso) : base(precioBase, peso)
        {
            carga = _carga;
        }

        public Lavadora(double precioBase, colores color, letrasConsumo consumoEnergetico, double peso, int carga) : base(precioBase, color, consumoEnergetico, peso)
        {
            this.carga = carga;
        }

        public int gCarga()
        {
            return carga;
        }

        public override double precioFinal()
        {
            double nuevoPrecio = base.precioFinal();

            if (carga > 30)
            {
                nuevoPrecio += 50;
            }

            return nuevoPrecio;
        }

    }
}
