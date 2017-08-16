using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EulerProblem14
{
    class Program
    {
        /*

        Problem:

        The following iterative sequence is defined for the set of positive integers:

        n → n/2 (n is even)
        n → 3n + 1 (n is odd)

        Using the rule above and starting with 13, we generate the following sequence:
        13 → 40 → 20 → 10 → 5 → 16 → 8 → 4 → 2 → 1

        It can be seen that this sequence (starting at 13 and finishing at 1) contains 10 terms. Although it has not been proved yet (Collatz Problem), it is thought that all starting numbers finish at 1.

        Which starting number, under one million, produces the longest chain?

        NOTE: Once the chain starts the terms are allowed to go above one million.

        
        */
        static void Main(string[] args)
        {
            long highestChain = 0;
            long theNumber = 2;
            long currentChain = 0;

            for (long i = 2; i < 1000000; i++)
            {
                currentChain = Collatz(i, 0);
                if (currentChain > highestChain)
                {
                    highestChain = currentChain;
                    theNumber = i;
                }
            }

            Console.WriteLine("The starting number with the longest Collatz chain under 1,000,000 is: {0}", theNumber);
            //answer is 837799
            Console.ReadLine();
        }

        //calculate number of Collatz chains given a starting number
        static long Collatz(long n, long chainNum)
        {
            //if n is even...
            if (n % 2 == 0)
            {
                chainNum++;
                return Collatz(n / 2, chainNum);
            }
            //if n is not 1, and not even, it must be odd...
            else if (n != 1)
            {
                chainNum++;
                return Collatz(3 * n + 1, chainNum);
            }
            //we've reached the end of the chain
            else
            {
                chainNum++;
                return chainNum;
            }
        }
    }
}
