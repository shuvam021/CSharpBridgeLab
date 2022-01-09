using System;

namespace CSharpBridgeLab.KudVenkat
{
    public class MainProgram
    {
        public static void MainMethod()
        {
            Console.WriteLine("Message: Accessing KudVenkat Files! \n\n");

            /*
             * part - 19
             *
            //Customer customer1 = new Customer();
            Customer customer1 = new Customer("Shuvam", "Das");
            customer1.PrintFullName();
            */

            /*
            // part - 20
            Circle circle1 = new Circle(5);
            Console.WriteLine(circle1.CalculateArea());

            Circle circle2 = new Circle(2);
            Console.WriteLine(circle2.CalculateArea());
            */

            // part - 21
            FullTimeEmployee FTE = new FullTimeEmployee();
            FTE.FirstName = "Shuvam";
            FTE.LastName = "Das";
            FTE.YearlySalary = 5000000.99F;
            FTE.PrintFullName();

            PartTimeEmployee PTE = new PartTimeEmployee();
            PTE.FirstName = "John";
            PTE.LastName = "Doe";
            PTE.HourlySalary= 29000.99F;
            PTE.PrintFullName();
        }
    }
}
