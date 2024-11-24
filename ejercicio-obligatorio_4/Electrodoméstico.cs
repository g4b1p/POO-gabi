using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_obligatorio_4
{
    internal class Electrodoméstico
    {
        protected double precioBase {  get; set; }
        protected colores color { get; set; }
        protected letrasConsumo consumoEnergetico { get; set; }
        protected double peso { get; set; }

        public enum colores
        {
            blanco,
            negro,
            rojo,
            azul,
            gris
        }

        public enum letrasConsumo
        {
            A,
            B,
            C,
            D,
            E,
            F
        }

        //vars por defecto
        protected double _precioBase = 100;
        protected colores _color = colores.blanco;
        protected letrasConsumo _consumoEnergetico = letrasConsumo.F;
        protected double _peso = 5;

        public Electrodoméstico()
        {
            precioBase = _precioBase;
            color = _color;
            consumoEnergetico = _consumoEnergetico;
            peso = _peso;
        }

        public Electrodoméstico(double precio, double peso)
        {
            this.precioBase = precio;
            this.peso = peso;
            color = _color;
            consumoEnergetico = _consumoEnergetico;
        }

        public Electrodoméstico(double precio, string color, char consumo, double peso)
        {
            this.precioBase = precio;

            this.color = _color;
            this.consumoEnergetico = _consumoEnergetico;

            this.peso = peso;
            
            /*if (comprobarColor(color))
            {
                this.color = color;
            }
            else
            {
                this.color = "blanco";
            }

            if (comprobarConsumoEnergetico(consumo))
            {
                this.consumoEnergetico = consumo;
            }
            else
            {
                this.consumoEnergetico = 'F';
            }*/
        }

        #region gets
        public double gPrecioBase()
        {
            return precioBase;
        }

        public colores gColor()
        {
            return color;
        }

        public letrasConsumo gConsumoEnergetico()
        {
            return consumoEnergetico;
        }

        public double gPeso()
        {
            return peso;
        }
        #endregion

        private bool comprobarConsumoEnergetico(letrasConsumo consumo)
        {
            foreach (letrasConsumo l in Enum.GetValues(typeof(letrasConsumo)))
            {
                if (consumo == l)
                {
                    return true;
                }
                /*else
                {
                    return false;
                }*/
            }
            consumo = _consumoEnergetico;
            return false;
        }

        private bool comprobarColor(colores color)
        {
            foreach (colores c in Enum.GetValues(typeof(colores)))
            {
                if (color == c)
                {
                    return true;
                }
            }
            color = _color;
            return false;
        }

        public virtual double precioFinal()
        {

            if (consumoEnergetico == letrasConsumo.A)
            {
                this.precioBase += 100;
            }
            else if (consumoEnergetico == letrasConsumo.B)
            {
                this.precioBase += 80;
            }
            else if (consumoEnergetico == letrasConsumo.C)
            {
                this.precioBase += 60;
            }
            else if (consumoEnergetico == letrasConsumo.D)
            {
                this.precioBase += 50;
            }
            else if (consumoEnergetico == letrasConsumo.E)
            {
                this.precioBase += 30;
            }
            else if (consumoEnergetico == letrasConsumo.F)
            {
                this.precioBase += 10;
            }

            if (peso >= 0 && peso <= 19)
            {
                this.precioBase += 10;
            }
            else if (peso >= 20 && peso <= 49)
            {
                this.precioBase += 50;
            }
            else if (peso >= 50 && peso <= 79)
            {
                this.precioBase += 80;
            }
            else if (peso >= 80)
            {
                this.precioBase += 100;
            }

            return precioBase;
        }
    }
}
