using System;

namespace CSharpBridgeLab
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("i. to run Utils file: 1");
            Console.WriteLine("i. to run Youtube file: 2");
            Console.WriteLine("i. to run Kudvenket file: 3");

            Step1:
            Console.Write("Your option: ");
            int option = int.Parse(Console.ReadLine());
            switch (option)
            {
                case 1:
                    Utils.MainProgram.MainMethod();
                        break;
                case 2:
                    Youtube.MainProgram.MainMethod();
                    break;
                case 3:
                    KudVenkat.MainProgram.MainMethod();
                    break;
                default:
                    goto Step1;
            }
        }
    }
}
