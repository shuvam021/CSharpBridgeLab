using System;


namespace CSharpBridgeLab.Utils
{
    internal class HarmonicNumber
    {
    /*
     * Harmonic Number
     * 
     * Desc -> Prints the Nth harmonic number: 1/1 + 1/2 + ... + 1/N 
     * (http://users.encs.concordia.ca/~chvatal/notes/harmonic.html).
     * I/P -> The Harmonic Value N. Ensure N != 0
     * Logic -> compute 1/1 + 1/2 + 1/3 + ... + 1/N
     * O/P -> Print the Nth Harmonic Value.
     */
    public static void GenSolution()
        {
            Console.WriteLine("Insert a number for harmonic value");
            int N = Convert.ToInt32(Console.ReadLine());
            double harmonicValue = 0;
            if (N != 0)
            {
                for (int i=1; i <= N; i++) 
                {
                    harmonicValue += (double) 1 / i;
                }
                Console.WriteLine("Result: Harmonic of " + N + " is = " + harmonicValue);
            }
            else
            {
                Console.WriteLine("Error: value must be greter than 0");
            }
        }
    }
}
