
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
            // Getters & Setters

            Car car = new Car(400);

            car.Speed = 100000000;

            Console.WriteLine(car.Speed);

            Console.ReadKey(); 
        }
    }

    class Car
    {
        private int speed;

        public Car(int speed)
        {
            Speed = speed;
        }

        public int Speed
        {
            get { return speed; } // read
            set                   // writable
            { 
                if (value > 500)
                {
                    speed = 500; 
                }
                else 
                {
                    speed = value; 
                }
            }
        }
    }
}