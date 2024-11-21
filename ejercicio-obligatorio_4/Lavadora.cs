using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_obligatorio_4
{
    internal class Lavadora : Electrodoméstico
    {
        private int carga;

        public Lavadora() : base()
        {
            carga = 5;
        }

        public Lavadora(double precioBase, double peso) : base(precioBase, peso)
        {
            carga = 5;
        }

        public Lavadora(double precioBase, string color, char consumoEnergetico, double peso, int carga) : base(precioBase, color, consumoEnergetico, peso)
        {
            this.carga = carga;
        }

        public int gCarga()
        {
            return carga;
        }

        public override double precioFinal()
        {
            double precioBase = base.precioFinal();

            if (carga > 30)
            {
                precioBase += 50;
            }

            return precioBase;
        }

    }
}
