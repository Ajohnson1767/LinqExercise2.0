using System;

namespace Switch_Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Whats your favorite subject?");
            var response = Console.ReadLine();

            switch (response)
            {
                case "Math":
                    Console.WriteLine($"Math is cool!");
                    break;
                case "English":
                    Console.WriteLine("Thats cool but I cant read");
                    break;
                default:
                    Console.WriteLine("Never heard of that one");
                    break;
            }
            
            
            
            
            int day = 1;
            switch (day)
            {
                case 0:
                    Console.WriteLine("Sunday");
                    break;
                case 1:
                    Console.WriteLine("Monday");
                    break;
                case 2:
                    Console.WriteLine("Tuesday");
                    break;
                case 3:
                    Console.WriteLine("Wednesday");
                    break;
                case 4:
                    Console.WriteLine("Thursday");
                    break;
                case 5:
                    Console.WriteLine("Friday");
                    break;
                case 6:
                    Console.WriteLine("Saturday");
                    break;
            }

        }
    }
}
