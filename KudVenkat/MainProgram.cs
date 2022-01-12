using System;

//https://youtube.com/playlist?list=PLAC325451207E3105

namespace CSharpBridgeLab.KudVenkat
{
    public enum Gender
    {
        Unknown,
        Male,
        Female
    }
    class SampleCustomer
    {
        public string Name { get; set; }
        public Gender Gender { get; set; }
    }
    public class MainProgram
    {
        public static string GetGender(Gender gender)
        {
            switch (gender)
            {
                case Gender.Unknown:
                    return "Unknown";
                case Gender.Male:
                    return "Male";
                case Gender.Female:
                    return "Female";
                default:
                    return "Invalid input";
            }
        }
        public static void MainMethod()
        {
            /*string msg = "Accessing KudVenkat Files!";
            Console.WriteLine($"Message: {msg} \n\n");*/

            /*
             * part - 56
             */

            bool stringEquation = GenericClass.AreEqual<string>("a", "a");
            bool intEquation = GenericClass.AreEqual<int>(1, 3);
            Console.WriteLine(stringEquation?"Equal":"NotEqual");
            Console.WriteLine(intEquation?"Equal":"NotEqual");

            /*
             * part - 45-47 Enum
             *
            SampleCustomer[] sampCustomer = new SampleCustomer[2];
            sampCustomer[0] = new SampleCustomer
            {
                Gender = Gender.Male,
                Name = "John"
            };
            sampCustomer[1] = new SampleCustomer
            {
                Gender = Gender.Female,
                Name = "Jane"
            };
            foreach(SampleCustomer c in sampCustomer)
            {
                Console.WriteLine($"Name = {c.Name} and Gender = {GetGender(c.Gender)}");
            }
            */

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

            /*
            // part - 21
            FullTimeEmployee FTE = new FullTimeEmployee
            {
                FirstName = "Shuvam",
                LastName = "Das",
                YearlySalary = 5000000.99F
            };

            FTE.PrintFullName();

            PartTimeEmployee PTE = new PartTimeEmployee();
            PTE.FirstName = "John";
            PTE.LastName = "Doe";
            PTE.HourlySalary= 29000.99F;
            PTE.PrintFullName();
            */

            /*
            //part 28
            StructCustomer customer1 = new StructCustomer(101, "Mark");
            customer1.PrintDetails();
            */
        }
    }
}
