using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_obligatorio_2
{
    class persona
    {
        private string nombre;

        private int edad;

        private string dni;

        private char sexo;

        private double peso;

        private double altura;

        private const char SEXO = 'H';

        public persona()
        {
            this.nombre = "";
            this.edad = 0;
            this.sexo = SEXO;
            this.peso = 0;
            this.altura = 0;
        }

        public persona (string nombre, int edad, char sexo)
        {
            this.nombre = nombre;
            this.edad = edad;
            this.sexo = sexo;

            this.dni = "";
            this.peso = 0;
            this.altura = 0;
        }

        public persona (string nombre, int edad, string dni, char sexo, double peso, double altura)
        {
            this.nombre = nombre;
            this.edad = edad;
            this.dni = dni;
            this.sexo = sexo;
            this.peso = peso;
            this.altura = altura;
        }

        public string gNombre()
        {
            return nombre;
        }
        public void sNombre(string nombreIngresado)
        {
            this.nombre = nombreIngresado;
        }


        public int gEdad()
        {
            return edad;
        }
        public void sEdad(int edadIngresado)
        {
            this.edad = edadIngresado;
        }


        public string gDni()
        {
            return dni;
        }
        public void sDni(string dniIngresado)
        {
            this.dni = dniIngresado;
        }


        public char gSexo()
        {
            return sexo;
        }
        public void sSexo(char sexoIngresado)
        {
            this.sexo = sexoIngresado;
        }


        public double gPeso()
        {
            return peso;
        }
        public void sPeso(double pesoIngresado)
        {
            this.peso = pesoIngresado;
        }


        public double gAltura()
        {
            return altura;
        }
        public void sAltura(double alturaIngresado)
        {
            this.altura = alturaIngresado;
        }


        public void calcularIMC(double peso, double altura)
        {
            double pesoIdeal = peso / Math.Pow(altura, 2); //const

            if (pesoIdeal < 20)
            {
                pesoIdeal = -1;
            }
            else if (pesoIdeal >= 20 && pesoIdeal <= 25)
            {
                pesoIdeal = 0;
            }
            else if (pesoIdeal > 25)
            {
                pesoIdeal = 1;
            }
        }

        public void esMayorDeEdad(int edad)
        {
            bool mayorEdad = false; //?

            if (edad >= 18)
            {
                mayorEdad = true;
            } 
            else
            {
                mayorEdad = false;
            }
        }

        public void comprobarSexo(char sexo)
        {
            if (sexo != 'H' && sexo != 'M')
            {
                sexo = 'H'; // defoult?
            }
        }

        public void generaDNI()
        {
            Random random = new Random();

            random.Next(10000000, 99999999);

            //double dniR = random / 23;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }
}