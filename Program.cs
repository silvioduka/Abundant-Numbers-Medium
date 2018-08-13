/*
Abundant Numbers - Medium from Coding Challenges
by Silvio Duka

Last modified date: 2018-03-10

If the sum of factors of a number is greater than twice that number, it is considered to be abundant. 

For example: 
12 is an abundant number. 
Factors of 12 are 1, 2, 3, 4, 6, 12 
Sum is 1 + 2 + 3 + 4 + 6 + 12 = 28 > 2 * 12 

Tasks: 
(Easy) Write a program to verify whether a given number is abundant or not. 
(Medium) Write a program to find all the abundant numbers in a range. 
(Hard) Given a number, write a program to display its factors, their sum and then verify whether it's abundant or not. 
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbundantNumbers
{
    class Program
    {
        static int start = 1; // Insert a start number of range to verify
        static int end = 199; // Insert a end number of range to verify

        static void Main(string[] args)
        {
            int i = 0;

            for (int number = start; number <= end; number++)
            {
                i += SumFact(number);
            }

            Console.WriteLine($"There are {i} abundant numbers in the range from {start} to {end}.");
        }

        static int SumFact(int n)
        {
            int sum = 0;

            for (int i = 1; i <= n; i++)
            {
                if (n % i == 0)
                {
                    sum += i;
                }
            }

            if (sum > 2 * n) { Console.WriteLine($"Number {n} is abundant number."); return 1; }

            return 0;
        }
    }
}