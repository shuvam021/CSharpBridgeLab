using System;

/*
 * https://www.youtube.com/watch?v=GhQdlIFylQ8&t=13901s 
 */

namespace CSharpBridgeLab.Youtube
{
    public class MainProgram
    {
        private static void Ajenda()
        {
            Console.WriteLine("Drawing a Shape \nVariables \nData Types \nWorking With Strings \nWorking With Numbers \nGetting User Input \nBuilding a Calculator \nBuilding a Mad Lib \nArrays \nMethods \nReturn Statement \nIf Statements \nIf Statements(con't) \nBuilding a Better Calculator \nSwitch Statements \nWhile Loops \nBuilding a Guessing Game \nFor Loops \nBuilding an Exponent Method \n2d Arrays \nComments \nException Handling \nClasses & Objects \nConstructors \nObject Methods \nGetters & Setters \nStatic Class Attributes \nStatic Methods & Classes \nInheritance");
        }
        private static void DrawingShape()
        {
            // Drawing a Shape
            Console.WriteLine("     .");
            Console.WriteLine("    /|");
            Console.WriteLine("   / |");
            Console.WriteLine("  /  |");
            Console.WriteLine(" /   |");
            Console.WriteLine("/____|");
            Console.ReadLine();
        }
        private static void VariableConcept()
        {
            //Variables
            //string characterName = "John";
            //int characterAge = 70;
            string characterName; int characterAge;
            characterName = "John"; characterAge = 70;
            Console.WriteLine("There once was a man named" + characterName);
            Console.WriteLine("He was " + characterAge + " years old");
            Console.WriteLine("He really liked the name" + characterName);
            Console.WriteLine("But didn't like being " + characterAge);
            Console.ReadLine();
        }
        private static void DatatypeConcept()
        {
            //Data Types
            string phrase = "Hello World !!!";  // string
            char grade = 'S';   // single character
            int age = 30;   // - whole no - + whole no
            //float < double < decimal
            double gpa = 3.3;
            bool isMale = true;
        }
        private static void StringConcept()
        {
            //Working With Strings
            string phrase = "Hello World!!!";
            Console.WriteLine(phrase);
            Console.WriteLine(phrase.Length);
            Console.WriteLine(phrase.ToUpper());
            Console.WriteLine(phrase.Contains("hii"));
            Console.WriteLine(phrase[4]);
            Console.WriteLine(phrase.IndexOf("w"));
            Console.WriteLine(phrase.Substring(6, 5));

        }
        private static void NumberConcept()
        {
            //Working With Numbers
            Console.WriteLine(5 + 8);
            Console.WriteLine(5 - 8);
            Console.WriteLine(5 * 8);
            Console.WriteLine(5 / 8);
            Console.WriteLine(5 / 8.0);
            Console.WriteLine(5 % 8);
            Console.WriteLine(5 + 8.1);

            //Math method
            Console.WriteLine(Math.Abs(-40));
            Console.WriteLine(Math.Pow(3, 8));
            Console.WriteLine(Math.Pow(3.9, 8));
            Console.WriteLine(Math.Sqrt(36));
            Console.WriteLine(Math.Max(4, 5));
            Console.WriteLine(Math.Min(5, 9));
            Console.WriteLine(Math.Round(6.4));
        }
        private static void UserInput()
        {
            //Getting User Input
            Console.Write("Enter your name: ");
            string name = Console.ReadLine();
            Console.WriteLine("Hello " + name);
        }
        private static void CalculatorApp()
        {
            //Building a Calculator

            Console.Write("Enter a Number: ");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter Operator: ");
            string op = Console.ReadLine();

            Console.Write("Enter another Number: ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            if (op == "+") Console.WriteLine(num1 + num2);
            else if (op == "-") Console.WriteLine(num1 - num2);
            else if (op == "*") Console.WriteLine(num1 * num2);
            else if (op == "/") Console.WriteLine(num1 / num2);
            else Console.WriteLine("Error: Invalid Input");
        }
        private static void MadLibsGame()
        {
            string color, pluralNoun, celebrity;

            Console.Write("Enter a color: ");
            color = Console.ReadLine();

            Console.Write("Enter plural noun: ");
            pluralNoun = Console.ReadLine();

            Console.Write("Enter celebrity name: ");
            celebrity = Console.ReadLine();

            Console.WriteLine("Roses are " + color);
            Console.WriteLine(pluralNoun + " are blue");
            Console.WriteLine("I Love " + celebrity);
        }
        private static void ArrayConcept()
        {
            // Arrays
            int[] luckyNumbers = { 4, 8, 15, 16, 23, 42 };
            Console.WriteLine(luckyNumbers);
            Console.WriteLine(luckyNumbers[4]);
            luckyNumbers[4] = 10;
            Console.WriteLine(luckyNumbers[4]);

            string[] friends = new string[5];
            friends[0] = "John";
        }
        private static string GetDay(int dayNum)
        {
            string dayName;

            switch (dayNum)
            {
                case 0:
                    dayName = "Sunday";
                    break;
                case 1:
                    dayName = "Monday";
                    break;
                case 2:
                    dayName = "Tuesday";
                    break;
                case 3:
                    dayName = "Wednesday";
                    break;
                case 4:
                    dayName = "Thursday";
                    break;
                case 5:
                    dayName = "Friday";
                    break;
                case 6:
                    dayName = "Saturday";
                    break;
                default:
                    dayName = "Error: Invalid day";
                    break;
            }

            return dayName;
        }
        private static void SwitchConcept()
        {
            Console.WriteLine(GetDay(10));
        }
        private static void WhileConcept()
        {
            int index = 1;
            while (index <= 5)
            {
                Console.WriteLine(index);
                index++;
            }
        }
        private static void GuessingGame()
        {
            //Building a Guessing Game
            string secretWord = "giraffe";
            string guess = "";
            int guessCount = 0;
            int guessLimit = 3;
            bool isOutOfGuesses = false;
            while (guess != secretWord && !isOutOfGuesses)
            {
                if (guessCount < guessLimit)
                {
                    Console.Write("Enter guess: ");
                    guess = Console.ReadLine();
                    guessCount++;
                }
                else
                {
                    isOutOfGuesses = true;
                }
            }
            if (isOutOfGuesses) Console.Write("You Lose!");
            else Console.Write("You Win!");
        }
        private static int ExponentMethod(int baseNum, int powNum)
        {
            //Building an Exponent Method
            int result = 1;
            for (int i = 0; i < powNum; i++)
            {
                result *= baseNum;
            }
            return result;
        }
        private static void TwoDArray()
        {
            int[,] numberGrid =
            {
                {1, 2},
                {3, 4},
                {5, 6}
            };
            Console.WriteLine(numberGrid[0, 0]);
        }
        public static void MainMethod()
        {
            Console.WriteLine("Message: Accessing Youtube Files! \n\n");
            
            /*
            Ajenda();
            Youtube.MainFile.DrawingShape();
            Youtube.MainFile.VariableConcept();
            Youtube.MainFile.DatatypeConcept();
            Youtube.MainFile.StringConcept();
            Youtube.MainFile.NumberConcept();
            Youtube.MainFile.UserInput();
            Youtube.MainFile.CalculatorApp();
            Youtube.MainFile.MadLibsGame();
            Youtube.MainFile.ArrayConcept();
            Youtube.MainFile.SwitchConcept();
            Youtube.MainFile.WhileConcept();
            Youtube.MainFile.GuessingGame();
            Console.WriteLine(Youtube.MainFile.ExponentMethod(4, 5));
            Youtube.MainFile.TwoDArray();
            */

            /*
            Youtube.Student student1 = new Youtube.Student("Jim", "Bus", 2.8);
            Youtube.Student student2 = new Youtube.Student("Pam", "Art", 3.6);
            Console.WriteLine(student1.HasHonors());
            Console.WriteLine(student2.HasHonors());
            */

            /*
            Youtube.Movie avengers = new Youtube.Movie("The Avengers", "Joss Whedon", "PG-13");
            Youtube.Movie shrek = new Youtube.Movie("Shrek", "Addam Adamson", "PG");
            Console.WriteLine(avengers.Rating);
            Console.WriteLine(shrek.Rating);
            */
        }
    }
}
