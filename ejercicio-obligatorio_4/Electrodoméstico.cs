using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_obligatorio_4
{
    internal class Electrodoméstico
    {
        protected double precioBase;
        protected string color;
        protected char consumoEnergetico;
        protected double peso;

        public Electrodoméstico()
        {
            this.precioBase = 100;
            this.color = "blanco";
            this.consumoEnergetico = 'F';
            this.peso = 5;
        }

        public Electrodoméstico(double precio, double peso)
        {
            this.precioBase = precio;
            this.peso = peso;
            this.color = "blanco";
            this.consumoEnergetico = 'F';
        }

        public Electrodoméstico(double precio, string color, char consumo, double peso)
        {
            this.precioBase = precio;
            this.peso = peso;

            if (comprobarColor(color))
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
            }
        }

        private bool comprobarColor(string color)
        {
            if (color == "blanco" || color == "negro" || color == "rojo" || color == "azul" || color == "gris")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private bool comprobarConsumoEnergetico(char consumo)
        {
            if (consumo == 'A' || consumo == 'B' || consumo == 'C' || consumo == 'D' || consumo == 'E' || consumo == 'F')
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public virtual double precioFinal()
        {
            double precio = precioBase;

            if (consumoEnergetico == 'A')
            {
                precio += 100;
            }
            else if (consumoEnergetico == 'B')
            {
                precio += 80;
            }
            else if (consumoEnergetico == 'C')
            {
                precio += 60;
            }
            else if (consumoEnergetico == 'D')
            {
                precio += 50;
            }


            if (peso < 20)
            {
                precio += 10;
            }
            else if (peso < 50)
            {
                precio += 50;
            }
            else if (peso < 80)
            {
                precio += 80;
            }
            else
            {
                precio += 100;
            }
            return precio;
        }

        public double gPrecioBase()
        {
            return precioBase;
        }

        public string gColor()
        {
            return color;
        }

        public char gConsumoEnergetico()
        {
            return consumoEnergetico;
        }

        public double gPeso()
        {
            return peso;
        }
    }
}
