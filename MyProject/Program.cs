
using System;
using System.ComponentModel.Design;
using System.IO.Pipes;
using System.Net.WebSockets;

namespace MyProject 
{
    class Program
    {
        static void Main()
        {
            // Exception & try catch

            double x;
            double y;
            double result;

            try
            {
                Console.Write("Enter number 1: ");
                x = Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter number 2: ");
                y = Convert.ToInt32(Console.ReadLine());

                result = x / y;

                Console.WriteLine("Result: " + result);
            }
            catch (FormatException e)
            {
                Console.WriteLine("Enter only numbers please.");
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine("You can't divide by zero!");
            }
            catch (Exception e)
            {
                Console.WriteLine("Something went wrong");
            }
            finally
            {
                Console.WriteLine("Thanks for visiting");
            }

            Console.ReadKey(); 
        }
        

    } 
}
