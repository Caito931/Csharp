
using System;
using System.Net.WebSockets;

namespace MyProject 
{
    class Program
    {
        static void Main()
        {
            // String methods
            String fullName = "Choraumm Mt";
            String phoneNumber = "123-456-7890";

            // fullName = fullName.ToUpper();
            // fullName = fullName.ToLower();
            // Console.WriteLine(fullName);

            // phoneNumber = phoneNumber.Replace("-", "");
            // Console.WriteLine(phoneNumber);

            // String userName = fullName.Insert(0, "Mr.");
            // Console.WriteLine(userName);

            // int lenght = fullName.Length;
            // Console.WriteLine(lenght);

            String firstName = fullName.Substring(0, 8);
            Console.WriteLine(firstName);

            String lastName = fullName.Substring(9, 2);
            Console.WriteLine(lastName);

            Console.ReadKey();
        }
    }
}

