
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
            // Objects as Arguments

            Car car1 = new Car("Mustang", "Red");

            Car car2 = Copy(car1);

            ChangeColor(car1, "silver");

            Console.WriteLine(car1.color + " " + car1.model);
            Console.WriteLine(car2.color + " " + car2.model);
            
            Console.ReadKey(); 
        }

        public static void ChangeColor(Car car, String color)
        {
            car.color = color;
        }

        public static Car Copy(Car car)
        {
            return new Car(car.model, car.color);
        }

    }
    class Car
    {
        public String model;
        public String color;

        public Car(String model, String color)
        {
            this.model = model;
            this.color = color;
        }
    }

}