using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EulerProblem5
{
    class Program
    {
        /*

        Problem:

        2520 is the smallest number that can be divided by each of the numbers from 1 to 10 without any remainder.

        What is the smallest positive number that is evenly divisible by all of the numbers from 1 to 20?

        */
        static void Main(string[] args)
        {
            /*
            We should know from our math classes that every integer can be expressed as a product of its prime divisors. So we could logically reduce this as:
            1, 2, 3, 5, 7, 11, 13, 17, 19
            will be all of the prime divisors for our number. But our number would also need to include all the composite numbers, e.g. 9, so we would need to square (or even cube in the case of 2) 
            some of these primes. Then we need to only figure out which of these primes will appear more than once.

            It follows:

            4 = 2^2
            8 = 2^3
            9 = 3^2
            16 = 2^4

            The rest can be obtained from combining the primes together (e.g. 10 = 5*2, 20 = 5*(2^2))

            So our number should be: (2^4)*(3^2)*5*7*11*13*17*19 = 232792560
            */

            /*
            A brute-force approach:
            */

            int number = 2520; //we know we can start here from the problem
            Program helper = new Program();

            while (true)
            {
                if (helper.test(number)){
                    //we've found our number!
                    break;
                }
                number += 2; //we can by default rule out all odd cases.
            }

            Console.WriteLine("Here is the smallest number that is evenly divisible by 1-20: {0}", number);
            Console.ReadLine();
        }

        //divisor test for 1-20
        bool test(int num)
        {
            for (int i = 1; i < 20; i++)
            {
                if (num % i != 0)
                {
                    //our number is not divisible by a certain number, return false
                    return false;
                }
            }
            return true;
        }
    }
}
