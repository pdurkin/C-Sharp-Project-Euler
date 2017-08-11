using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EulerProblem4
{
    class Program
    {
       /*

       Problem:

       A palindromic number reads the same both ways. The largest palindrome made from the product of two 2-digit numbers is 9009 = 91 × 99.

       Find the largest palindrome made from the product of two 3-digit numbers.

       */

        static void Main(string[] args)
        {
            //brute force method... start from 999 and test against all other 3 digit numbers, then deincrement to 998, etc...
            int i = 999;
            int j = 0;
            int bigPal = 0;
            int factor1 = 0;
            int factor2 = 0;
            Program helper = new Program();
           
            for(; i > 100; i--)
            {
                //Do not need to check j against any value higher than i because it will have already been checked in a previous loop.
                j = i;

                for (; j > 100; j--)
                {
                    //if it's a palindrome...
                    if (helper.isPalindrome(i * j))
                    {
                        //if it's bigger than the last palindrome we found...
                        if ((i*j) > bigPal)
                        {
                            bigPal = i * j;
                            factor1 = i;
                            factor2 = j;
                        }
                    }
                }
            }

            Console.WriteLine("The  largest palindrome is: {0}, made from {1}*{2}", bigPal, factor1, factor2);
            Console.ReadLine();
        }

        bool isPalindrome(int x)
        {
            string number = x.ToString();

            //need to know the halfway mark for checking palindrome.
            int halfway;

            if (number.Length % 2 == 1)
            {
                halfway = (number.Length+1)/ 2;
            }
            else
            {
                halfway = number.Length / 2;
            }

            //check if given number is a palindrome. Start from opposite sides.
            int i = 0;
            int j = number.Length - 1;

            while(i <= halfway)
            {
                //if at any point in the string the characters are not equal, return false.
                if(number[i] != number[j])
                {
                    return false;
                }
                i++;
                j--;
            }

            return true;
        }
    }
}
