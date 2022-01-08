using System;

namespace CSharpBridgeLab.Utils
{
    internal class SwapTwoNum
    {
        public static void GenSolution()
        {
            Console.Write("Enter number a: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter number b: ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Pre swap: a = {0} and b = {1}", a, b);
            int temp = a;
            a = b;
            b = temp;
            Console.WriteLine("Post swap: a = {0} and b = {1}", a, b);
        }
    }
}
