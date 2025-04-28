
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
            // Object

            Human human1 = new Human();
            Human human2 = new Human();

            human1.name = "Rick";
            human1.age = 65;
            human2.name = "Morty";
            human2.age = 16;

            human1.Eat();
            human1.Sleep();
            human2.Eat();
            human2.Sleep();

            Console.ReadKey(); 
        }

    } 

}