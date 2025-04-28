
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
            // String interpolation
            String firstName = "Choraumm";
            String lastName = "MT";
            int age = 100;
            
            //Console.WriteLine("Hello " + firstName + " " + lastName + ".");
            //Console.WriteLine("You are " + age + " years old.");

            Console.WriteLine($"Hello {firstName} {lastName}.");
            Console.WriteLine($"You are {age,-10} years old.");

            Console.ReadKey(); 
        }
        

    } 
}
