using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpBridgeLab.KudVenkat
{
    class Customer
    {
        string _firstName;
        string _lastName;

        // Constructor overloading
        // Constructor with out parameter Works in 2010 version but not in .NET3.1
        // public Customer() : this("No prarmeter is providef") { }

        public Customer(string FirstName, string LastName)
        {
            // Constructure
            this._firstName = FirstName;
            this._lastName = LastName;
        }

        public void PrintFullName()
        {
            Console.WriteLine("Fullname = {0}, LastName = {1}", this._firstName, this._lastName);
        }

        ~Customer()
        {
            // Destructor
            // Clean up code
        }
    }
}
