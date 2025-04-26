
using System;
using System.Net.WebSockets;

namespace MyProject 
{
    class Program
    {
        static void Main()
        {
            int x; // Declaration
            x = 123; // Initialization

            int y = 321; // Declaration && Initialization

            int z = x + y;

            int age = 21; // whole integer
            double height = 300.5; // decimal number
            bool alive = true; // true or false
            char symbol = '@'; // character
            String name = "Caio"; // string (multiple characters)
            String userName = symbol + name;

            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine(z);
            Console.WriteLine("Your age is " + age);
            Console.WriteLine("Your height is " + height + " cm");
            Console.WriteLine("Are you alive?: " + alive);
            Console.WriteLine("Your symbil is: " + symbol);
            Console.WriteLine("Hello " + name);
            Console.WriteLine("Your username is: " + userName);

            Console.ReadKey();
        }
    }
}

