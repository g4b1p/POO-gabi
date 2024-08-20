using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace evalucaion_1
{
    internal class Laptop : ProductoElectronico
    {
        public int MemoriaRAM { get; set; }

        public Laptop(string Nombre, double Precio, string Marca, int MemoriaRAM) : base(Nombre, Precio, Marca)
        {
            this.MemoriaRAM = MemoriaRAM;
        }

        public override void MostrarDetalles()
        {
            Console.WriteLine("Nombre: " + Nombre);
            Console.WriteLine("Precio: " + Precio);
            Console.WriteLine("Marca: " + Marca);
            Console.WriteLine("MemoriaRAM: " + MemoriaRAM);
        }
    }
}