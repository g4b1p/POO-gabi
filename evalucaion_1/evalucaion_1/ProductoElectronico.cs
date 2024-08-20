using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace evalucaion_1
{
    public class ProductoElectronico
    {
        private string nombre;
        private double precio;
        private string marca;

        public string Nombre { get { return nombre; } set { nombre = value; } }
        public double Precio { get { return precio; } set { precio = value; } }
        public string Marca { get { return marca; } set { marca = value; } }

        public ProductoElectronico(string nombre, double precio, string marca)
        {
            this.nombre = nombre;
            this.precio = precio;
            this.marca = marca;
        }

        public virtual void MostrarDetalles()
        {
            Console.WriteLine("Nombre: " + nombre);
            Console.WriteLine("Precio: " + precio);
            Console.WriteLine("Marca: " + marca);
        }
    }
}