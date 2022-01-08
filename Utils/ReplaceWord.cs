using System;
using System.IO;

namespace CSharpBridgeLab.Utils
{
    public static class ReplaceWord
    {
        private const string Template = "Hello <<UserName>>, How are you?";
        
        private static void ReplaceStrWithTemplate(string param)
        {
            string result = Template.Replace("<<UserName>>", param);
            Console.WriteLine("After replace: " + result);
        }
        
        public static void GenSolution()
        {
            Console.WriteLine("Please enter your Username");
            string name = Console.ReadLine() ?? throw new IOException("Empty value is provided");
            
            if (name.Length >= 3) ReplaceStrWithTemplate(name);
            else Console.WriteLine("Please provide your username as atleast 3 character");
        }
    }
}