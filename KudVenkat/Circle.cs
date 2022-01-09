using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpBridgeLab.KudVenkat
{
    class Circle
    {
        static float _PI;
        int _Radius;

        static Circle()
        {
            //*static constructor
            //should be before other constructor

            Circle._PI = 3.141F;
        }
        public Circle(int Radius)
        {
            this._Radius = Radius;
        }
        public float CalculateArea()
        {
            return this._Radius * _PI * this._Radius;
        }
    }
}