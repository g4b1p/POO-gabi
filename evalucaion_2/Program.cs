using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace evalucaion_2
{
    class Empleado
    {
        private string nombre;
        public string Nombre {  get { return nombre; } set { nombre = value; } }

        private int edad;
        public int Edad { get { return edad; } set { edad = value; } }

        private double salario;
        public double Salario { get { return salario; } set { salario = value; } }

        public Empleado(string nombre, int edad, double salario)
        {
            this.nombre = nombre;
            this.edad = edad;
            this.salario = salario;
        }

        public Empleado()
        {
            this.nombre = "";
            this.edad = 0;
            this.salario = 0;
        }

        public virtual void mostrarInfo() 
        {
            Console.WriteLine("nombre: " + nombre); // en minuscula (campo) xq estas dentro de la clase
            Console.WriteLine("edad: " + edad);
            Console.WriteLine("salario: " + salario);
        }
    }

    class Gerente : Empleado
    {
        private string depto;
        public string Dpto { get { return depto; } set { depto = value; } }

        public Gerente (string nombre, int edad, double salario, string depto) : base (nombre, edad, salario)
        {
            this.depto = depto;
        }

        public override void mostrarInfo()
        {
            Console.WriteLine("nombre: " + Nombre); // en mayuscula (propiedad) xq estas fuera de la clase
            Console.WriteLine("edad: " + Edad);
            Console.WriteLine("salario: " + Salario);
            Console.WriteLine("salario: " + depto);
        }
    }

    class Operario : Empleado
    {
        private string turno;
        public string Turno { get { return turno; } set { turno = value; } }

        public Operario(string nombre, int edad, double salario, string turno) : base(nombre, edad, salario)
        {
            this.turno = turno;
        }

        public override void mostrarInfo()
        {
            Console.WriteLine("nombre: " + Nombre);
            Console.WriteLine("edad: " + Edad);
            Console.WriteLine("salario: " + Salario);
            Console.WriteLine("salario: " + turno);
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Gerente gerente = new Gerente("raul", 23, 10400.5, "contabilidad");
            
            List<Operario> opererios = new List<Operario>();

            Operario operario1 = new Operario("raul", 23, 3400.5, "mañana");
            Operario operario2 = new Operario("jose", 21, 5900.5, "tarde");
            Operario operario3 = new Operario("juli", 40, 5400.5, "noche");
            Operario operario4 = new Operario("mica", 25, 3700.5, "tarde");

            opererios.Add(operario1);
            opererios.Add(operario2);
            opererios.Add(operario3);
            opererios.Add(operario4);

            foreach (var operario in opererios)
            {
                operario.mostrarInfo();
                Console.WriteLine();
            }

            int cantOpMañana = 0;
            int cantOpTarde = 0;
            int cantOpNoche = 0;

            foreach (var op in opererios)
            {
                if (op.Turno != null)
                {
                    if (op.Turno == "mañana")
                    {
                        cantOpMañana++;
                        Console.WriteLine(op.Nombre + " trabaja en la mañana");
                    }
                    else if (op.Turno == "tarde")
                    {
                        cantOpTarde++;
                        Console.WriteLine(op.Nombre + " trabaja en la tarde");
                    }
                    else
                    {
                        cantOpNoche++;
                        Console.WriteLine(op.Nombre + " trabaja en la noche");
                    }
                }
            }

            Console.WriteLine();
            Console.WriteLine("cantidad de operarios en la mañana: " + cantOpMañana);
            Console.WriteLine("cantidad de operarios en la tarde: " + cantOpTarde);
            Console.WriteLine("cantidad de operarios en la noche: " + cantOpNoche);

            Console.WriteLine();
            Console.WriteLine("nombre de gerente: " + gerente.Nombre);

            Console.ReadKey();
        }
    }
}
