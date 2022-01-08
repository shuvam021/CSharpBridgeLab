using System;

namespace CSharpBridgeLab.Utils
{
    internal class PowerOfTwo
    {
        /*
         * Power of 2
         * ===========
         * Desc -> This program takes a command-line argument N and prints 
         * a table of the powers of 2 that are less than or equal to 2^N.
         * I/P -> The Power Value N. Only works if 0 <= N < 31 since 2^31 overflows an int
         * Logic -> repeat until i equals N.
         * O/P -> Print the power of 2 table or 2^N 
        */
        public static void GenSolution()
        {
            Console.WriteLine("Insert a number");
            int N = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("======================");

            if (0 <= N && N < 31)
            {
                for (int i=1; i <= N; i++) Console.WriteLine("2^" + i + " = " + Math.Pow(2, i));
            }
            else Console.WriteLine("Error: Out of range");
        }
    }
}
