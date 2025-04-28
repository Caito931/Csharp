
using System;

namespace MyProject
{
    class Car 
    {
        String make;
        String model;
        int year;
        String color;
        public static int numberOfCars;

        public Car(String make, String model, int year, String color)
        {
            this.make = make;
            this.model = model;
            this.year = year;
            this.color = color;
            numberOfCars += 1;
        }

        public void Drive()
        {
            Console.WriteLine("You drive the " + make + " " + model);
        }

        public static void StartRace()
        {
            Console.WriteLine("The race was begun!");
        }
    }
}