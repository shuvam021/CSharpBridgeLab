using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpBridgeLab.KudVenkat
{
    public struct StructCustomer
    {
        private int _id;
        private string _name;
        public string Name { get => _name; set => _name = value; }
        public int Id { get => _id; set => _id = value; }
        public StructCustomer(int Id, string Name)
        {
            this._id = Id;
            this._name = Name;
        }
        public void PrintDetails()
        {
            Console.WriteLine($"Id = {this._id}, Name = {this._name}");
        }
    }
}
