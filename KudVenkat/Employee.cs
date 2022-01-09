using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpBridgeLab.KudVenkat
{
    public class Employee
    {
        public string FirstName;
        public string LastName;
        public string Email;

        public void PrintFullName()
        {
            Console.WriteLine("Employee Name {0} {1}", this.FirstName, this.LastName);
        }
    }

    public class FullTimeEmployee : Employee
    {
        public float YearlySalary;
    }

    public class PartTimeEmployee : Employee
    {
        public float HourlySalary;
    }
}
