
using System;
using System.IO.Pipes;
using System.Net.WebSockets;

namespace MyProject 
{
    class Program
    {
        static void Main()
        {
            // Calculator

            do
            {
                double num1 = 0;
                double num2 = 0;
                double result = 0;

                // Menu
                Console.WriteLine("-------------------");
                Console.WriteLine("Calculator Program");
                Console.WriteLine("-------------------");

                // Number 1
                Console.Write("Enter number 1: ");
                num1 = Convert.ToDouble(Console.ReadLine());

                // Number 2
                Console.Write("Enter number 2: ");
                num2 = Convert.ToDouble(Console.ReadLine());

                // Operator
                Console.WriteLine("Enter an Option: ");
                Console.WriteLine("\t+ : Add");
                Console.WriteLine("\t- : Subtract");
                Console.WriteLine("\t* : Multiply");
                Console.WriteLine("\t/ : Divide");
                Console.Write("Enter a option: ");

                // Result
                switch (Console.ReadLine())
                {
                    case "+":
                        result = num1 + num2;
                        Console.WriteLine($"Your result: {num1} + {num2} = {result}");
                        break;
                    case "-":
                        result = num1 - num2;
                        Console.WriteLine($"Your result: {num1} - {num2} = {result}");
                        break;
                    case "*":
                        result = num1 * num2;
                        Console.WriteLine($"Your result: {num1} * {num2} = {result}");
                        break;
                    case "/":
                        if (num2 != 0)
                        {
                            result = num1 / num2;
                            Console.WriteLine($"Your result: {num1} / {num2} = " + result);
                        }
                        else
                        {
                            Console.WriteLine("You can't divide by zero");
                        }

                        break;
                    default:
                        Console.WriteLine("That was not a valid option");
                        break;
                }

                // Continue?
                Console.WriteLine("Would you like to continue? (Y/N): ");

            } while (Console.ReadLine().ToUpper() == "Y");

            // Feedback
            Console.WriteLine("Bye!");
            Console.ReadKey(); 
        } 
    } 
}
