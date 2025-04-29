
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
            // ToString()

            Car car = new Car("Chevy", "Corvette", 2022, "Blue");

            //Console.WriteLine(car.ToString());
            Console.WriteLine(car);
            
            Console.ReadKey(); 
        }
    }

    class Car
    {
        String make;
        String model;
        int year;
        String color;

        public Car(String make, String model, int year, String color)
        {
            this.make = make;
            this.model = model;
            this.year = year;
            this.color = color;
        }
        public override string ToString()
        {
            return "This is a " + make + " " + model;
        }
    }
}