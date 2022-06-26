using System;

namespace calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            double numOne = 0;
            double numTwo = 0;
            Console.WriteLine("Calculator\n-------------");
            //Get user input for first number, inside of while loop so user does not attempt to divide by zero
            while (numOne == 0)
            {
                Console.WriteLine("Type first number: ");
                numOne = Convert.ToDouble(Console.ReadLine());
            }
            //Get user input for second number, inside of while loop so user does not attempt to divide by zero
            while (numTwo == 0)
            {
                Console.WriteLine("Type second number: ");
                numTwo = Convert.ToDouble(Console.ReadLine());
            }
            //Display operator choices to user 
            Console.WriteLine("Math operators:");
            Console.WriteLine("\ta - Add");
            Console.WriteLine("\ts - Subtract");
            Console.WriteLine("\tm - Multiply");
            Console.WriteLine("\td - Divide");
            Console.WriteLine("\tp - Power of");
            Console.WriteLine("\tr - remainder of");
            Console.Write("Select Operator ");
            //Take user input, convert to upper case so that the switch can take lower and upper case
#pragma warning disable CS8602 // Dereference of a possibly null reference.
            switch (Console.ReadLine().ToUpper())
#pragma warning restore CS8602 // Dereference of a possibly null reference.
            {
                default:
                    Console.WriteLine("Invalid Choice, try again");
                    break;
                //Add
                case "A":
                    Console.BackgroundColor = ConsoleColor.Green;
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"Your Result: {numOne} + {numTwo} = " + (numOne + numTwo));
                    //reset console colour after printing result
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.ForegroundColor = ConsoleColor.White;

                    break;
                //Subtract
                case "S":
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.WriteLine($"Your Result: {numOne} - {numTwo} = " + (numOne - numTwo));
                    //reset console colour after printing result
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.ForegroundColor = ConsoleColor.White;
                    break;
                //Multiply
                case "M":
                    Console.BackgroundColor = ConsoleColor.White;
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine($"Your Result: {numOne} * {numTwo} = " + (numOne * numTwo));
                    //reset console colour after printing result
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.ForegroundColor = ConsoleColor.White;
                    break;
                //Divide
                case "D":
                    Console.BackgroundColor = ConsoleColor.Blue;
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.WriteLine($"Your Result: {numOne} / {numTwo} = " + (numOne / numTwo));
                    //reset console colour after printing result
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.ForegroundColor = ConsoleColor.White;
                    break;
                //Power
                case "P":
                    Console.BackgroundColor = ConsoleColor.Green;
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine($"Your Result: {numOne} to the power of {numTwo} = " + Math.Pow(numOne, numTwo));
                    //reset console colour after printing result
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.ForegroundColor = ConsoleColor.White;
                    break;
                //Remainder
                case "R":
                    Console.BackgroundColor = ConsoleColor.Yellow;
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"Your Result: remainder of {numOne} / {numTwo} = " + (numOne % numTwo));
                    //reset console colour after printing result
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.ForegroundColor = ConsoleColor.White;
                    break;
            }
        }
    }
}
