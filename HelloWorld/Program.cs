using System;

namespace HelloWorld
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Hello, Bryanna!");

			string name = "";
			string job = "";
			int age = 0;
			int year = 0;
			int favnum1 = 0;
			int favnum2 = 0;


			Console.WriteLine("Please enter your name: ");
			name = Console.ReadLine();
			Console.WriteLine("Please enter your age at the end of this year: ");
			age = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("Please enter the year: ");
			year = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("Please enter where you work: ");
			job = Console.ReadLine();
			Console.WriteLine("Please enter your first favorite number: ");
			favnum1 = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("Please enter your second favorite number: ");
			favnum2 = Convert.ToInt32(Console.ReadLine());


			Console.WriteLine("Hello! My name is {0} and I am {1} years old. I was born in {2}. I work at {3}. My two favorite numbers added togther are {4}. ", name, age, year-age, job, favnum1+favnum2);
		}
	}
}
