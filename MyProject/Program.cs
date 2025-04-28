
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
            // Paranms keyword
            
            double total = CheckOut(3.99, 5.75, 15, 1.00, 10.25);
            
            Console.WriteLine(total);
            Console.ReadKey(); 
        }
        
        static double CheckOut(params double[] prices)
        {
            double total = 0;

            foreach (double price in prices)
            {
                total += price;
            }
            return total;
        }

    } 
}
