
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
            // Polymorphism

            Car car = new Car();
            Bicycle bicycle = new Bicycle();
            Boat boat = new Boat();

            // All in common
            Vehicle[] vehicles = {car, bicycle, boat};

            foreach (Vehicle vehicle in vehicles)
            {
                vehicle.Go();
            }
            
            Console.ReadKey(); 
        }
    }

    class Vehicle
    {
        public virtual void Go(){}
    }
    class Car : Vehicle
    {
        public override void Go()
        {
            Console.WriteLine("The car is moving!");
        }
    }
    class Bicycle : Vehicle
    {
        public override void Go()
        {
            Console.WriteLine("The bicycle is moving!");
        }
    }
    class Boat : Vehicle
    {
        public override void Go()
        {
            Console.WriteLine("The boat is moving!");
        }
    }
}