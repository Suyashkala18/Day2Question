using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindPrime
{
    class Program
    {
        static bool findPrime(int num)
        {
            for (int i = 2; i <= num/2; i++)
            {
                if(num%i==0)
                {
                    return false;
                }
            }
            return true;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the min number");
            int min = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the max number");
            int max = Convert.ToInt32(Console.ReadLine());

            for (int i = min; i <=max; i++)
            {
                if (findPrime(i))
                {
                    Console.WriteLine(i);
                }
            }
            Console.ReadKey();
        }
    }
}
