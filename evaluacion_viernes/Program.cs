using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace evaluacion_viernes
{
    interface IVehiculo
    {
        string Marca { get; set; }
        string Modelo { get; set; }

        string obtenerInfo();
    }

    abstract class Vehiculo : IVehiculo
    {
        public string Marca { get; set; }
        public string Modelo { get; set; }

        public Vehiculo (string marca, string modelo)
        {
            Marca = marca;
            Modelo = modelo;
        }

        public virtual string obtenerInfo()
        {
            return "marca: " + Marca + " / modelo: " + Modelo;
        }
    }

    class Coche : Vehiculo
    {
        public int NumeroPuertas { get; set; }

        public Coche (string marca, string modelo, int numeroPuertas) : base (marca, modelo)
        {
            NumeroPuertas = numeroPuertas;
        }

        public override string obtenerInfo()
        {
            return "marca: " + Marca + " / modelo: " + Modelo + " / puertas: " + NumeroPuertas;
        }
    }

    class Motocicleta : Vehiculo
    {
        public bool TieneSidecar { get; set; }

        public Motocicleta (string marca, string modelo, bool tieneSidecar) : base (marca, modelo)
        {
            TieneSidecar = tieneSidecar;
        }

        public override string obtenerInfo()
        {
            return "marca: " + Marca + " / modelo: " + Modelo + " / tiene sidercar: " + TieneSidecar;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            List<IVehiculo> listadeVehiculos = new List<IVehiculo>();

            Coche coche = new Coche("chevrrolet", "0km", 6);
            Motocicleta motocicleta = new Motocicleta("ford", "7.13.6", false);
            
            listadeVehiculos.Add(coche);
            listadeVehiculos.Add(motocicleta);

            foreach (var vehiculos in listadeVehiculos)
            {
                Console.WriteLine(vehiculos.obtenerInfo());
            }
            Console.ReadKey();
        }
    }
}
