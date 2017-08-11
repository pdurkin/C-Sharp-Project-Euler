using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EulerProblem3
{
    class Program
    {
        /*

        Problem:

        The prime factors of 13195 are 5, 7, 13 and 29.

        What is the largest prime factor of the number 600851475143 ?

        */
        static void Main(string[] args)
        {
            //What is the greatest prime factor of 600851475143?

            //we know the greatest factor of i must be no greater than its sqrt
            int i = (int) Math.Sqrt(600851475143);
            Program n = new Program();
            for (; i > 1; i--)
            {
                //if i is a factor...
                if (600851475143 % i == 0)
                {
                    //if i is prime...
                    if (n.isPrime(i))
                    {
                        //i is the first prime
                        Console.WriteLine(i);
                        Console.ReadLine();
                        break;
                    }
                }
            }
        //answer is 6857... correct!
        }

        bool isPrime(int x)
        {
            bool s = true;
            //we know the greatest factor of x must be no greater than its sqrt
            int i = (int) Math.Sqrt(x);

            //check to see if x is prime
            while (i > 1)
            {
                if (x % i == 0)
                {
                    //then x is not prime
                    s = false;
                    break;
                }
                i--;
            }

            return s;
        }
    }
}
