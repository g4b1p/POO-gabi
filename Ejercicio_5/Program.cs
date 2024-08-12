using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace Ejercicio_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ahorcado");
            string palabra_a_adivinar = "esternocleidomastoideo";
            List<string> letras_a_adivinadar = new List<string>();
            int intentos = 0;
            for (int i = 0; i < palabra_a_adivinar.Length; i++)
            {
                letras_a_adivinadar.Add("_");
            }

            do
            {
                Console.Clear();
                Console.Write("La palabra es: ");
                foreach (string l in letras_a_adivinadar)
                {
                    Console.Write(l + " ");
                }
                Console.WriteLine();

                Console.Write("letra adivinada: ");
                string letra = Console.ReadLine();

                if (palabra_a_adivinar.Contains(letra))
                {
                    for (int i = 0; i < palabra_a_adivinar.Length; i++)
                    {
                        if (palabra_a_adivinar[i].ToString() == letra) // ToString() : convierte el caracter en una cadena pa coparar
                        {
                            letras_a_adivinadar[i] = letra;
                        }
                    }
                    intentos++;
                }
                else
                {
                    intentos++;
                }

            } while (letras_a_adivinadar.Contains("_"));

            Console.Clear();
            Console.WriteLine("FELICIDADES, la palabra era: " + palabra_a_adivinar);
            Console.WriteLine("ganaste con " + intentos + " intentos");

            Console.ReadKey();
        }
    }
}