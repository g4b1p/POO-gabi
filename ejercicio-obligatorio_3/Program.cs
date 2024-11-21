using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_obligatorio_3
{
    class password
    {
        private int longitud;

        private string contraseña;

        public password()
        {
            longitud = 8;
            //generarPassword();
        }

        public password(int longitud)
        {
            this.longitud = longitud;
            generarPassword();
        }

        private void generarPassword()
        {
            Random random = new Random();
            string caracteres = "abcdefghijklmñnopqrstuvwxyzABCDEFGHIJKLMNÑOPQRSTUVWXYZ0123456789";
            contraseña = "";

            for (int i = 0; i < longitud; i++)
            {
                //contraseña = caracteres[random.Next(caracteres)];
                contraseña += caracteres[random.Next(caracteres.Length)];
            }
        }

        public bool esFuerte()
        {
            int mayus = 0;
            int minus = 0;
            int nums = 0;

            foreach (char c in contraseña)
            {
                if (c >= 'A' && c <= 'Z')
                {
                    mayus++;
                }
                else if (c >= 'a' && c <= 'z')
                {
                    minus++;
                }
                else if (c >= '0' && c <= '9')
                {
                    nums++;
                }
            }

            if (mayus > 2 && minus > 1 && nums > 5)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public string gContraseña()
        {
            return contraseña;
        }

        public int gLongitud()
        {
            return longitud;
        }

        public void sLongitud(int nuevaLong)
        {
            longitud = nuevaLong;
            generarPassword();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("cantidad de contraseñas a generar: ");
            int cantidad = int.Parse(Console.ReadLine());

            Console.WriteLine("longitud de las contraseñas: ");
            int longitud = int.Parse(Console.ReadLine());

            password[] passwords = new password[cantidad];
            bool[] fuerte = new bool[cantidad];

            for (int i = 0; i < cantidad; i++)
            {
                passwords[i] = new password(longitud);
                fuerte[i] = passwords[i].esFuerte();
            }

            for (int i = 0; i < cantidad; i++)
            {
                Console.WriteLine(passwords[i].gContraseña());
                Console.WriteLine(fuerte[i]);
            }

            Console.ReadKey();
        }
    }
}
