using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace maxCPU
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 20; i++)
            {
                Task.Run(() => findPrimeNubers());
            }
            Console.ReadKey();
        }
        static void findPrimeNubers()
        {
            int counter = 3;
            while (true)
            {
                isPrimeNumber(counter);
                counter++;
            }
        }
        static bool isPrimeNumber(int argTarget)
        {
            bool isPrime = true;
            for (int i = 2; i < argTarget; i++)
            {
                if (argTarget % i == 0)
                {
                    isPrime = false;
                    break;
                }
            }
            return isPrime;
        }
    }
}
