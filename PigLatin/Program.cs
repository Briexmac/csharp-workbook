
using System;

namespace PigLatin
{
	class Program
	{
		public static void Main()
		{
			// your code goes here
			Console.WriteLine("Please enter a word or sentence to translate into PigLatin.");
			string input = Console.ReadLine();

			string [] words = input.Split(' ');
			foreach (string word in words)
			{
				Console.WriteLine(TranslateWord(word));
			}
		}
		
		public static string TranslateWord(string word)
		{
			word = word.ToLower();
			int firstVowelIndex = word.IndexOfAny(new char[]{'a', 'e', 'i', 'o', 'u', 'y'});
			// leave this command at the end so your program does not close automatically
			if(firstVowelIndex <= 0)
			{
				return word + "yay";
			}
			else
			{
				string firstPart = word.Substring(0, firstVowelIndex);
				string secondPart = word.Substring(firstVowelIndex);

				return secondPart + firstPart + "ay";
			}
		}

	}
}