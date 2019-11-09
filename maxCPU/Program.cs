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
            Console.Write(isPrimeNumber(7));
            Console.ReadKey();
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
