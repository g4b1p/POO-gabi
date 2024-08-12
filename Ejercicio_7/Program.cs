using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace Ejercicio_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("cauntos numeros desea ingresar: ");
            int cantNums = int.Parse(Console.ReadLine());
            List<int> nums = new List<int>();

            for (int i = 1; i <= cantNums; i++)
            {
                Console.WriteLine(i + "° numero: ");
                int num = int.Parse(Console.ReadLine());
                nums.Add(num);
            }

            int numMenor = nums[0];
            int numMayor = nums[0];
            foreach (int n in nums)
            {
                if (n > numMayor)
                {
                    numMayor = n;
                }

                if (n < numMenor)
                {
                    numMenor = n;
                }
            }
            Console.WriteLine();
            Console.WriteLine("el numero mayor es: " + numMayor);
            Console.WriteLine("el numero menor es: " + numMenor);

            Console.ReadKey();
        }
    }
}