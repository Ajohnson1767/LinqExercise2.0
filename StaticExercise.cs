using System;

namespace ConsoleApp13
{
    class Program
    {
        static void Main(string[] args)
        {
            var cel = TempConverter.FahrenheitToCelsius(98);

            Console.WriteLine($"{cel}");

            var fahrenheit = TempConverter.CelsiusToFahrenheit(32);

            Console.WriteLine($"{fahrenheit}");
        }
    }
}
