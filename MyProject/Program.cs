
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
            // Static

            Car car1 = new Car("Ford", "Mustang", 2022, "Red");
            Car car2 = new Car("Chevy", "Corette", 2021, "Blue");
            Car car3 = new Car("Toyota", "Corolla", 2025, "White");

            car1.Drive();
            car2.Drive();
            car3.Drive();

            Car.StartRace();
            Console.WriteLine(Car.numberOfCars);

            Console.ReadKey(); 
        }

    } 

}