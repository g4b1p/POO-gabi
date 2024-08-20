using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace evalucaion_1
{
    internal class Televisor : ProductoElectronico
    {
        public string Resolucion { get; set; }

        public Televisor(string Nombre, double Precio, string Marca, string Resolucion) : base(Nombre, Precio, Marca)
        {
            this.Resolucion = Resolucion;
        }

        public override void MostrarDetalles()
        {
            Console.WriteLine("Nombre: " + Nombre);
            Console.WriteLine("Precio: " + Precio);
            Console.WriteLine("Marca: " + Marca);
            Console.WriteLine("Resolucion: " + Resolucion);
        }
    }
}