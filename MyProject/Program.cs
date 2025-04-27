
using System;
using System.IO.Pipes;
using System.Net.WebSockets;

namespace MyProject 
{
    class Program
    {
        static void Main()
        {
            // Arrays

            String[] cars = new string[3];
            // String[] cars = {"BMW", "Mustang", "Corvette"};

            cars[0] = "Tesla";
            cars[1] = "Mustang";
            cars[2] = "Corvette";

            for (int i = 0; i < cars.Length; i++)
            {
                Console.WriteLine(cars[i]);
            }
            
            Console.ReadKey(); 
        } 
    } 
}
