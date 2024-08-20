using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace evalucaion_1
{
    internal class Telefono : ProductoElectronico
    {
        string SistemaOperativo { get;  set; }
        
        public Telefono(string Nombre, double Precio, string Marca, string SistemaOperativo) : base(Nombre, Precio, Marca)
        {
            this.SistemaOperativo = SistemaOperativo;
        }

        public override void MostrarDetalles()
        {
            Console.WriteLine("Nombre: " + Nombre);
            Console.WriteLine("Precio: " + Precio);
            Console.WriteLine("Marca: " + Marca);
            Console.WriteLine("SistemaOperativo: " + SistemaOperativo);
        }
    }
}