
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
            // Overloaded Constructors

            Pizza pizza = new Pizza("stuffed crust", "red sauce", "mozzarella");

            Console.ReadKey(); 
        }

    } 

    class Pizza
    {
        String bread;
        String sauce;
        String cheese;
        String topping;

        public Pizza(String bread) 
        {
            this.bread = bread;
        }
        public Pizza(String bread, String sauce) 
        {
            this.bread = bread;
            this.sauce = sauce;
        }
        public Pizza(String bread, String sauce, String cheese) 
        {
            this.bread = bread;
            this.sauce = sauce;
            this.cheese = cheese;
        }
        public Pizza(String bread, String sauce, String cheese, String topping) 
        {
            this.bread = bread;
            this.sauce = sauce;
            this.cheese = cheese;
            this.topping = topping;
        }
    }

}