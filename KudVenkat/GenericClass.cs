using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpBridgeLab.KudVenkat
{
    internal class GenericClass
    {
        public static bool AreEqual<PlaceHolderForDataType>(PlaceHolderForDataType param1, PlaceHolderForDataType param2)
        {
            return param1.Equals(param2);
        }
    }
}
