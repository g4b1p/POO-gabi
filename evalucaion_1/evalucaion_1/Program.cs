using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace evalucaion_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            ProductoElectronico productoElectronico = new ProductoElectronico("celu", 124, "io");

            productoElectronico.MostrarDetalles();

            Console.ReadKey();
            */


            //CREO OBJETOS

            Televisor televisor = new Televisor("tv", 12476, "philips", "4k");
            Laptop laptop  = new Laptop("lpt", 17435, "microsoft", 200);
            Telefono telefono = new Telefono("iphone", 13848, "apple", "IO");

            List<ProductoElectronico> productosElectronicos = new List<ProductoElectronico>();

            productosElectronicos.Add(televisor);
            productosElectronicos.Add(laptop);
            productosElectronicos.Add(telefono);


            //RECORRO OBJETOS

            foreach (var producto in productosElectronicos)
            {
                producto.MostrarDetalles();
                Console.WriteLine();
            }


            //BUSCO OBJETO

            Console.WriteLine("ingrse el nombre que busca: ");
            string nombreBuscado = Console.ReadLine();

            bool encontrado = false;

            foreach (var p in productosElectronicos)
            {
                //string x = p.Nombre;
                if (p.Nombre == nombreBuscado)
                {
                    Console.WriteLine("ese nombre esta en la lista");
                    Console.WriteLine();
                    encontrado = true;
                }
            }
            if (!encontrado)
            {
                Console.WriteLine("ese nombre no esta en la lista");
                Console.WriteLine();
            }


            //ELIMINO OBJETO

            Console.WriteLine("ingrse el nombre que desea eliminar: ");
            string nombreaEliminar = Console.ReadLine();

            bool encontrado2 = false;

            foreach (var p in productosElectronicos) //e?
            {
                if (p.Nombre == nombreaEliminar)
                {
                    productosElectronicos.Remove(p);
                    Console.WriteLine("producto eliminado");
                    Console.WriteLine();
                    encontrado2 = true;

                    foreach (var producto in productosElectronicos)
                    {
                        producto.MostrarDetalles();
                        Console.WriteLine();
                    }
                }
            }
            if (!encontrado2)
            {
                Console.WriteLine("ese nombre no esta en la lista");
                Console.WriteLine();
            }


            //PUNTO ADICIONAL: AGREGO OBJETO

            ProductoElectronico nuevoProducto = null;

            Console.WriteLine("q tipo de producto desea añadir: (televisor, laptop, telefono): ");
            string tipoProducto = Console.ReadLine();

            Console.WriteLine("nombre de producto nuevo: ");
            string nuevoNombre = Console.ReadLine();
            Console.WriteLine("precio de producto nuevo: ");
            int nuevoPrecio = int.Parse(Console.ReadLine());
            Console.WriteLine("marca de producto nuevo: ");
            string nuevaMarca = Console.ReadLine();


            switch(tipoProducto)
            {
                case "televisor":
                    Console.WriteLine("resolucion del televisor: ");
                    string resolucion = Console.ReadLine();
                    nuevoProducto = new Televisor(nuevoNombre, nuevoPrecio, nuevaMarca, resolucion);
                    break;
                case "laptop":
                    Console.WriteLine("memoria de laptop: ");
                    int memoria = int.Parse(Console.ReadLine());
                    nuevoProducto = new Laptop(nuevoNombre, nuevoPrecio, nuevaMarca, memoria);
                    break;
                case "telefono":
                    Console.WriteLine("SO de telefono: ");
                    string sistemaOperativo = Console.ReadLine();
                    nuevoProducto = new Telefono(nuevoNombre, nuevoPrecio, nuevaMarca, sistemaOperativo);
                    break;
            }

            if (nuevoProducto != null)
            {
                productosElectronicos.Add(nuevoProducto);
                Console.WriteLine("producto agregado");
                Console.WriteLine();
                foreach (var producto in productosElectronicos)
                {
                    producto.MostrarDetalles();
                    Console.WriteLine();
                }
            }

            Console.ReadKey();
        }
    }
}