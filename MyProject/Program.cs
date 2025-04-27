
using System;
using System.IO.Pipes;
using System.Net.WebSockets;

namespace MyProject 
{
    class Program
    {
        static void Main()
        {
            // Return

            double x;
            double y;
            double result;

            Console.WriteLine("Enter in number 1: ");
            x = Convert.ToDouble(Console.ReadLine());
            
            Console.WriteLine("Enter in number 2: ");
            y = Convert.ToDouble(Console.ReadLine());

            result = Multiply(x, y);

            Console.WriteLine("The result is: " + result);
            
            Console.ReadKey(); 
        }

        static double Multiply(double x, double y)
        {
            //double z = x * y;
            //return z;
            return x * y;
        }

    } 
}
