
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
            // Array of Objects

            // Car[] garage = new Car[3];

            // Car car1 = new Car("Mustang");
            // Car car2 = new Car("Corvette");
            // Car car3 = new Car("Lambo");

            // garage[0] = car1;
            // garage[1] = car2;
            // garage[2] = car3;

            Car[] garage = {new Car("Mustang"), new Car("Corvette"), new Car("Lambo")};

            // Console.WriteLine(garage[0].model);
            // Console.WriteLine(garage[1].model);
            // Console.WriteLine(garage[2].model);

            foreach (Car car in garage) 
            {
                Console.WriteLine(car.model);
            }
            

            Console.ReadKey(); 
        }

    }
    class Car
    {
        public String model;

        public Car(String model)
        {
            this.model = model;
        }
    }

}