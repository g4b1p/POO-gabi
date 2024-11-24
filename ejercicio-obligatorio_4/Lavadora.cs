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

        public Lavadora(double precioBase, string color, char consumoEnergetico, double peso, int carga) : base(precioBase, color, consumoEnergetico, peso)
        {
            this.carga = carga;
        }

        public int gCarga()
        {
            return carga;
        }

        public override double precioFinal() //explicar
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
