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

        // vars por defecto
        private int _longitud = 8;
        private string _contraseña = " ";

        private static Random random = new Random();

        public password()
        {
            longitud = _longitud;
            contraseña = _contraseña;
        }

        public password(int longitud)
        {
            this.longitud = longitud;
            generarPassword();
        }

        /*public bool esFuerte() //?
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
        }*/

        private void generarPassword()
        {
            string caracteres = "abcdefghijklmñnopqrstuvwxyzABCDEFGHIJKLMNÑOPQRSTUVWXYZ0123456789";
            string contraseña = "";

            for (int i = 0; i < longitud; i++)
            {
                //contraseña = caracteres[random.Next(caracteres[i])].ToString();
                contraseña += caracteres[random.Next(caracteres.Length)];
            }
            Console.WriteLine(contraseña);
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

            // ARREGLARRRR

            Console.WriteLine("cuantas contraseñas generara: ");
            int cantidad = int.Parse(Console.ReadLine());

            Console.WriteLine("longitud de las contraseñas: ");
            int longitud = int.Parse(Console.ReadLine());

            //password p  = new password();

            //p.sLongitud(cantidad);
            //p.gContraseña();

            password[] passwords = new password[cantidad]; 
            //bool[] fuerte = new bool[cantidad];

            for (int i = 0; i < cantidad; i++)
            {
                passwords[i] = new password(longitud);
                //fuerte[i] = passwords[i].esFuerte();

                Console.WriteLine(passwords[i].gContraseña());
                //Console.WriteLine(fuerte[i]);
            }

            Console.ReadKey();
        }
    }
}
