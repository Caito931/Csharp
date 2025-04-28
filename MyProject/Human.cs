
using System;
using System.Security.Cryptography;

namespace MyProject
{
    class Human
    {
        public String name = "";
        public int age;
        
        public void Eat()
        {
            Console.WriteLine(name + " is eating");
        }
        public void Sleep()
        {
            Console.WriteLine(name + " is sleeping");
        }

    }

}
