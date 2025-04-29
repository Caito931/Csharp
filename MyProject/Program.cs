
using System;
using System.Collections.Generic;
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
            // Auto Implemented Properties

            Car car = new Car("Porsche");

            Console.WriteLine(car.Model);

            Console.ReadKey(); 
        }
    }

    class Car
    {
        public String Model { get; set; }

        public Car(String model)
        {
            this.Model = model;
        }
    }
}