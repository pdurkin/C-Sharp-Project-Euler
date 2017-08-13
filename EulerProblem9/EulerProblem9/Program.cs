using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EulerProblem9
{
    class Program
    {
        /*

        Problem:

        A Pythagorean triplet is a set of three natural numbers, a < b < c, for which,
        a^2 + b^2 = c^2

        For example, 3^2 + 4^2 = 9 + 16 = 25 = 5^2.

        There exists exactly one Pythagorean triplet for which a + b + c = 1000.
        Find the product abc.

        */
        static void Main(string[] args)
        {
            //brute force...
            int a = 0, b = 0, c = 0;

            for (int i = 1; i < 1000; i++)
            {
                for (int j = 1; j < 1000; j++)
                {
                    for (int k = 1; k < 1000; k++)
                    {
                        if(checkTriplets(i, j, k))
                        {
                            if (i + j + k == 1000)
                            {
                                a = i;
                                b = j;
                                c = k;
                                goto Done;
                            }
                        }                   
                    }
                }
            }

            Done:
            Console.WriteLine("The pythagorean triplet such that a + b + c = 1000 is: {0}, {1}, {2}", a, b, c);
            Console.WriteLine("Their product is: {0}", a * b * c);
            Console.ReadLine();
        }

        static bool checkTriplets(int a, int b, int c)
        {
            if ((a != b) && (b!= c)){
                if (a*a + b*b == c*c)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
