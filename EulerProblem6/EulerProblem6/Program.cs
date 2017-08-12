using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EulerProblem6
{
    class Program
    {
        /*

        Problem: 

        The sum of the squares of the first ten natural numbers is,
        1^2 + 2^2 + ... + 10^2 = 385

        The square of the sum of the first ten natural numbers is,
        (1 + 2 + ... + 10)^2 = 55^2 = 3025

        Hence the difference between the sum of the squares of the first ten natural numbers and the square of the sum is 3025 − 385 = 2640.

        Find the difference between the sum of the squares of the first one hundred natural numbers and the square of the sum.

        */
        static void Main(string[] args)
        {
            long sumOfSquares = 0;
            long squareOfSum;
            long theDifference;

            //know from Gauss that the sum of the first n numbers = ((n+1)*n)/2
            squareOfSum = (((100+1)*100)/2);

            //sum up the first 100 squares
            for(int i = 1; i <= 100; i++)
            {
                sumOfSquares += i * i;
            }

            theDifference = squareOfSum * squareOfSum - sumOfSquares;
            Console.WriteLine("The difference between the sum of the squares and the square of the sums of the first one hundred natural numbers is: {0}", theDifference);
            //asnwer is: 25164150
            Console.ReadLine();
        }
    }
}
