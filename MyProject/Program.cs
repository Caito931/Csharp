
using System;
using System.ComponentModel.Design;
using System.IO.Pipes;
using System.Net.WebSockets;

namespace MyProject 
{
    class Program
    {
        static void Main()
        {
            // Class
            
            Messages.Hello();
            Messages.Waiting();
            Messages.Bye();

            Console.ReadKey(); 
        }

    } 

}