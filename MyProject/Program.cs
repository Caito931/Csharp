
using System;
using System.IO.Pipes;
using System.Net.WebSockets;

namespace MyProject 
{
    class Program
    {
        static void Main()
        {
            // Method

            String name = "Choraumm";
            int age = 100;
            
            singHappyBirthday(name, age);
            
            Console.ReadKey(); 
        }

        static void singHappyBirthday(String birthdayBOY, int yearsOld)
        {
            Console.WriteLine("Happy Birthday to you!");
            Console.WriteLine("Happy Birthday to you!");
            Console.WriteLine("Happy Birthday dear " + birthdayBOY);
            Console.WriteLine("You are " + yearsOld + " years old!");
            Console.WriteLine("Happy Birthday to you!");
            Console.WriteLine();
        }
    } 
}
