using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_obligatorio_2
{
    class persona
    {
        private string nombre;
        private int edad;
        public string dni { get; set; }
        private char sexo;
        private double peso;
        private double altura;

        // valores por defecto
        private string _nombre = " ";
        private int _edad = 0;
        private const char _sexo = 'h';
        private double _peso = 0;
        private double _altura = 0;

        private static Random random = new Random();

        public persona()
        {
            nombre = _nombre;
            edad = _edad;
            sexo = _sexo;
            peso = _peso;
            altura = _altura;
        }

        public persona(string nombre, int edad, char sexo)
        {
            this.nombre = nombre;
            this.edad = edad;
            this.sexo = sexo;
            peso = _peso;
            altura = _altura;
        }

        public persona(string nombre, int edad, char sexo, double peso, double altura)
        {
            this.nombre = nombre;
            this.edad = edad;
            this.sexo = sexo;
            comprobarSexo();
            this.peso = peso;
            this.altura = altura;
        }

        #region set de los atributos
        public void sNombre(string nombreIngresado)
        {
            this.nombre = nombreIngresado;
        }

        public void sEdad(int edadIngresado)
        {
            this.edad = edadIngresado;
        }

        public void sSexo(char sexoIngresado)
        {
            this.sexo = sexoIngresado;
        }

        public void sPeso(double pesoIngresado)
        {
            this.peso = pesoIngresado;
        }

        public void sAltura(double alturaIngresado)
        {
            this.altura = alturaIngresado;
        }
        #endregion

        public int calcularIMC()
        {
            int sobrepeso = 1;
            int pesoIdeal = 0;
            int infrapeso = -1;
            
            double pesoActual = peso / Math.Pow(altura, 2);

            if (pesoActual > 25)
            {
                return sobrepeso;
            }
            else if (pesoActual >= 20 && pesoActual <= 25)
            {
                return pesoIdeal;
            }
            else
            {
                return infrapeso;
            }
        }

        public bool esMayorDeEdad()
        {
            bool mayorEdad = false;

            if (edad >= 18)
            {
                mayorEdad = true;
            }
            else
            {
                mayorEdad = false;
            }
            return mayorEdad;
        }

        public void comprobarSexo()
        {
            if (sexo != 'h' && sexo != 'm')
            {
                this.sexo = _sexo;
            }
        }

        private string generaDNI() // dni argento
        {
            int dniGenerado = random.Next(10000000, 100000000);
            
            return dni = dniGenerado.ToString();
        }

        public void mostrarInfo()
        {
            Console.WriteLine("info de persona ");
            Console.WriteLine("nombre: " + nombre);
            Console.WriteLine("edad: " + edad);

            if (esMayorDeEdad() == true)
            {
                Console.WriteLine("es mayor de edad");
            }
            else
            {
                Console.WriteLine("no es mayor de edad");
            }

            string sexo_;

            if (this.sexo == 'h')
            {
                sexo_ = "hombre";
            }
            else
            {
                sexo_ = "mujer";
            }

            Console.WriteLine("sexo: " + sexo_);
            Console.WriteLine("dni: " + dni);
            Console.WriteLine("peso: " + peso);
            Console.WriteLine("altura: " + altura);

            if (calcularIMC() > 0)
            {
                Console.WriteLine("la persona tiene sobrepeso");
            }
            else if (calcularIMC() == 0)
            {
                Console.WriteLine("la persona esta en su peso ideal");
            }
            else
            {
                Console.WriteLine("la persona tiene infrapeso");
            }

            Console.WriteLine();
        }

        internal class Program
        {
            static void Main(string[] args)
            {

                List <persona> personas = new List<persona>();

                Console.WriteLine("ingrese su nombre: ");
                string nombre = Console.ReadLine();

                Console.WriteLine("ingrese su edad: ");
                int edad = int.Parse(Console.ReadLine());

                Console.WriteLine("ingrese su sexo (h o m): ");
                char sexo = char.Parse(Console.ReadLine());

                Console.WriteLine("ingrese su peso: ");
                double peso = double.Parse(Console.ReadLine());

                Console.WriteLine("ingrese su altura: ");
                double altura = double.Parse(Console.ReadLine());

                Console.WriteLine();

                persona persona1 = new persona(nombre, edad, sexo, peso, altura);
                persona persona2 = new persona(nombre, edad, sexo);
                persona persona3 = new persona();

                persona3.sNombre("raul");
                persona3.sEdad(19);
                persona3.sSexo('h');
                persona3.sPeso(68.4);
                persona3.sAltura(1.78);

                persona2.sPeso(81.1);
                persona2.sAltura(1.72);

                personas.Add(persona1);
                personas.Add(persona2);
                personas.Add(persona3);

                foreach (persona p in personas)
                {
                    p.generaDNI();
                    p.calcularIMC();
                    p.esMayorDeEdad();
                    p.mostrarInfo();
                }

                Console.ReadKey();
            }
        }
    }
}