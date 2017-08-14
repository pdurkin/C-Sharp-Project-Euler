using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EulerProblem10
{
    class Program
    {
        /*

        The sum of the primes below 10 is 2 + 3 + 5 + 7 = 17.

        Find the sum of all the primes below two million.

        */
        static void Main(string[] args)
        {
            long primesum = 0;

            for (long i = 2; i < 2000000; i++)
            {
                if (isPrime(i))
                {
                    primesum += i;
                }
            }

            Console.WriteLine("Sum of all primes below two million is: {0}", primesum);
            //Answer is 142913828922
            Console.ReadLine();
        }

        static bool isPrime(long x)
        {
            //we know the greatest factor of x must be no greater than its sqrt
            long i = (long)Math.Sqrt(x);

            //check to see if x is prime
            while (i > 1)
            {
                if (x % i == 0)
                {
                    //then x is not prime
                    return false;
                }
                i--;
            }

            return true;
        }
    }
}
