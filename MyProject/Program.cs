
using System;
using System.Net.WebSockets;
using System; 
using System.Net.WebSockets; 
namespace MyProject 
{
    class Program
    {
        static void Main()
        {
            // While loop
            String name = "";
            while (name == "")
            {
                Console.Write("Enter your name: "); 
                name = Console.ReadLine();
            } 
            
            Console.WriteLine("Hello " + name);
            
            Console.ReadKey(); 
        } 
    } 
}
