using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1Part1
{
	class Program
	{
		static void Main(string[] args)
		{ 
			//A welcome header for the user to the program
			Console.WriteLine("Welcome to \"Do these numbers kind of match when added in some wonky way?\"");

			//This line enters the string to the console window asking the user to enter a three digit number
			Console.WriteLine("Enter a three digit number");

			//Here we initialize the string variable Number1 with the number the user enters in the command window
			string Number1=Console.ReadLine();

			//Purely for aesthetics in the console window
			Console.WriteLine();

			//This line enters the string to the console window asking the user to enter a second three digit number
			Console.WriteLine("Enter another three digit number");

			//Here we initialize the string variable Number2 with the number the user enters in the command window
			string Number2 = Console.ReadLine();

			/*On this line we are adding the first two place holders of the strings entered by the user and initializing
			  that value as an integer variable named hundreds*/
			int hundreds = Number1[0] + Number2[0];

			/*On this line we are adding the second two place holders of the strings entered by the user and initializing
			  that value as an integer variable named tens*/
			int tens = Number1[1] + Number2[1];

			/*On this line we are adding the third two place holders of the strings entered by the user and initializing
			  that value as an integer variable named ones*/
			int ones = Number1[2] + Number2[2];

			//Aesthetic blankline in console
			Console.WriteLine();

			/*Here the if statement is using the equals comparison operator to see if the hundreds variable is equal 
			  to the tens variable and if the tens variable is equal to the ones variable. We are using the AND operator
			  between the two comparisons because we cannot compare three variables at once.*/
			if (hundreds == tens && tens == ones)
			
			//If the variables are all equal the program will write the line true to the console window
			{
				Console.WriteLine("True, the wonky sums do match!");
			}

			//If the variables do not equal eachother the program will write the line false to the console window
			else
			{
				Console.WriteLine("False, the wonky sums do not match!");
			}

			//This line allows the console window to stay open until the user presses any key
			Console.ReadKey();

		
		
				
		}
	}
}
