using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace maxCPU
{
    class Program
    {
        /// <summary>
        ///     <para>The main method</para>
        /// </summary>
        /// <param name="args">An array holding additional parameters</param>
        static void Main(string[] args)
        {
            for (int i = 0; i < 100; i++)
            {
                Task.Run(() => findPrimeNubers());
            }
            Console.ReadKey();
        }

        /// <summary>
        ///     <para>Continuously call 'isPrimeNumber' with diffrent target numbers</para>
        ///     <para>Used as the main method for all other threads</para>
        /// </summary>
        static void findPrimeNubers()
        {
            int counter = 3;
            while (true)
            {
                isPrimeNumber(counter);
                counter++;
            }
        }

        /// <summary>
        ///     <para>Tests if any given number (the 'target') is a prime number or not</para>
        /// </summary>
        /// <param name="argTarget">The 'target' number</param>
        /// <returns>Boolean value representing wether the 'target' number is a prime number or not</returns>
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
