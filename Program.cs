using System;

namespace if_else_project
{
    class Program
    {
		static void Main(string[] args)
		{
			int favNumber = 200;


			string input = Console.ReadLine();

			int userGuess = int.Parse(input);

			if (userGuess == favNumber)
			{
				Console.WriteLine($"Correct!");
			}
			else if (userGuess > favNumber) 
			{
				Console.WriteLine($"Too High!");
			}
			else
			{
				Console.WriteLine($"Too Low!");

            }
				
		
	
		

