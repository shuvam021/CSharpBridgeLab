using System;


namespace CSharpBridgeLab.Utils
{
    internal class GenerateFactorial
    {
        public static void GenSolution()
        {
            /*
             * Factors
             * 
             * Desc->Computes the factorization of N.
             * I/P->Number to find the factors
             * Logic->Traverse till i*i <= N instead of i <= N for efficiency.
             * O / P->Print the factors of number N
             */
            Console.Write("Number to find the factors: ");
            int N = Convert.ToInt32(Console.ReadLine());
            int factor = 1;
            if (N == 0) Console.WriteLine("Result: factorial of " + N + " is = " + 1);
            else
            {
                for (int i=1; i <= N; i++)
                {
                    factor *= i;
                }
                Console.WriteLine("Result: factorial of " + N + " is = " + factor);
            }
        }
    }
}
