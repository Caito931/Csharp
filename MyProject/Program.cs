
using System;
using System.Net.WebSockets;

namespace MyProject 
{
    class Program
    {
        static void Main()
        {
            // for loop
            /*
            for (int i = 1; i <= 10; i+=3)
            {
                Console.WriteLine(i);
            }
            */

            for (int i = 10; i > 0; i--)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("Happy new year!");
            
            Console.ReadKey(); 
        } 
    } 
}
