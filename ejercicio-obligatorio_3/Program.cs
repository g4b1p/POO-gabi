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

        public bool esFuerte()
        {
            int cantMayus = 0;
            int cantMinus = 0;
            int cantNums = 0;

            for (int i = 0; i < contraseña.Length; i++)
            {
                if ((contraseña[i] >= 'a' && contraseña[i] <= 'z') || contraseña[i] == 'ñ')
                {
                    cantMinus++;
                }
                else if ((contraseña[i] >= 'A' && contraseña[i] <= 'Z') || contraseña[i] == 'Ñ')
                {
                    cantMayus++;
                }
                else if (contraseña[i] >= '0' && contraseña[i] <= '9')
                {
                    cantNums++;
                }
            }

            Console.WriteLine("mayus:" + cantMayus + ", minus:" + cantMinus + ", nums:" + cantNums);

            if (cantMayus > 2 && cantMinus > 1 && cantNums > 5)
            {
                Console.WriteLine("es fuerte");
                return true;
            }
            else
            {
                Console.WriteLine("no es fuerte");
                return false;
            }                        
        }

        private void generarPassword()
        {
            //string caracteres = "abcdefghijklmñnopqrstuvwxyzABCDEFGHIJKLMNÑOPQRSTUVWXYZ0123456789";

            string minus = "abcdefghijklmñnopqrstuvwxyz";
            string mayus = "ABCDEFGHIJKLMNÑOPQRSTUVWXYZ";
            string nums = "0123456789";

            contraseña = "";

            contraseña += minus[random.Next(minus.Length)];
            contraseña += mayus[random.Next(mayus.Length)];
            contraseña += nums[random.Next(nums.Length)];

            string caracteres = minus + mayus + nums;

            for (int i = 3; i < longitud; i++)
            {
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
            Console.WriteLine("cuantas contraseñas generara: ");
            int cantidad = int.Parse(Console.ReadLine());

            Console.WriteLine("longitud de las contraseñas: ");
            int longitud = int.Parse(Console.ReadLine());

            password p  = new password();

            //p.sLongitud(longitud);
            //p.gContraseña();
            //p.esFuerte();

            password[] passwords = new password[cantidad];
            bool[] fuerte = new bool[cantidad];
            
            for (int i = 0; i < cantidad; i++)
            {
                passwords[i] = new password(longitud);
                passwords[i].gContraseña();
                fuerte[i] = passwords[i].esFuerte();
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
