using System;

namespace SwitchStatements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("what is your favorite class?");
            var favClass = (Console.ReadLine());
            switch (favClass)
            {
                case "Math":
                    Console.WriteLine("Oh i hate math"); 
                    break;
                case "English":
                    Console.WriteLine("I bet you love books");
                    break;
                case "Science":
                    Console.WriteLine("Thats also my favorite!");
                    break;
                case "History":
                    Console.WriteLine("Thats a great one!");
                    break;
                case "Gym":
                    Console.WriteLine("Nice, being active is great");
                    break;
                default:
                    Console.WriteLine("Oh weird i have not heard of that");
                    break;






            }
        } 
    
    }
}  


