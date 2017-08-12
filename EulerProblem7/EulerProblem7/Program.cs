using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EulerProblem7
{
    class Program
    {
        /*

        Problem:

        By listing the first six prime numbers: 2, 3, 5, 7, 11, and 13, we can see that the 6th prime is 13.

        What is the 10 001st prime number?

        */
        static void Main(string[] args)
        {
            //Brute Force approach...
            //we'll start with 2 already counted and skip checking the even numbers
            int primeCounter = 1;
            int latestPrime = 2;
            int i = 3;
            Program helper = new Program();

            while (primeCounter != 10001)
            {
                if (helper.isPrime(i))
                {
                    primeCounter++;
                    latestPrime = i;
                }
                i += 2; //don't need to check even numbers (we started on 3)
            }

            Console.WriteLine("The 10001st prime is: {0}", latestPrime);
            Console.ReadLine();
        }

        bool isPrime(int x)
        {
            //we know the greatest factor of x must be no greater than its sqrt
            int i = (int)Math.Sqrt(x);

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
