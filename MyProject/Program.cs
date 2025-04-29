
using System;
using System.ComponentModel.Design;
using System.IO.Pipes;
using System.Net.WebSockets;
using System.Text.RegularExpressions;

namespace MyProject 
{
    class Program
    {
        static void Main()
        {
            // Method Overriding

            Dog dog = new Dog();
            Cat cat = new Cat();

            dog.Speak();
            cat.Speak();
            
            Console.ReadKey(); 
        }
    }

    class Animal 
    {
        public virtual void Speak()
        {
            Console.WriteLine("The animal goes *brrr*");
        }
    }
    class Dog : Animal
    {
        public override void Speak()
        {
            Console.WriteLine("The dog goes *woof*");
        }
    }
    class Cat : Animal
    {
        public override void Speak()
        {
            Console.WriteLine("The cat goes *miau*");
        }
    }
}