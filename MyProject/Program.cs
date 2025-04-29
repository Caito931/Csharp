
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
            // List

            // String[] food = new string[3];

            // food[0] = "pizza";
            // food[1] = "hamburguer";
            // food[2] = "hotdog";

            List<String> food = new List<String>();

            // food.Add("fries");
            food.Add("pizza");
            food.Add("hamburguer");
            food.Add("hotdog");
            food.Add("fries");

            // food.Remove("fries");
            // food.Insert(0, "sushi");
            // Console.WriteLine(food.Count);
            // Console.WriteLine(food.IndexOf("pizza"));
            // Console.WriteLine(food.LastIndexOf("fries"));
            // Console.WriteLine(food.Contains("pizza"));
            // food.Sort();
            // food.Reverse();
            // food.Clear();
            String[] foodArray = food.ToArray();

            foreach (String item in food)
            {
                Console.WriteLine(item);    
            }
            // foreach (String item in foodArray)
            // {
            //     Console.WriteLine(item);    
            // }

            // Console.WriteLine(food[0]);

            Console.ReadKey(); 
        }
    }
}