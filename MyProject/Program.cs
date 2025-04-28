
using System;
using System.IO.Pipes;
using System.Net.WebSockets;

namespace MyProject 
{
    class Program
    {
        static void Main()
        {
            // Method Overloading

            double total;

            total = Multiply(2, 3, 4);

            Console.WriteLine(total);
            Console.ReadKey(); 
        }
        
        static double Multiply(double x, double y)
        {
            //double z = x * y;
            //return z;
            return x * y;
        }
        static double Multiply(double a, double b, double c)
        {
            return a * b * c;
        }

    } 
}
