﻿using System;

namespace PigLatin
{
    class Program
    {
        public static void Main()
        {
            // your code goes here
            string word = "";
            Console.WriteLine("Enter a word or sentence?");
            word = Console.ReadLine();
            Console.WriteLine(TranslateWord(word.ToLower()));
            // leave this command at the end so your program does not close automatically
            
            Console.ReadLine();
        }
        
        public static string TranslateWord(string word)
        {
            // your code goes here
            int firstVowel = word.IndexOfAny(new char[] {'a', 'e', 'i', 'o', 'u'});

            string partOne = word.Substring(0,firstVowel);
            string partTwo = word.Substring(firstVowel);
            word = word.ToLower();

            if (firstVowel == 0)
            {
                return word + "yay";
            }
            else
            {
                return partTwo + partOne + "ay";
            }

            // string[] words = word.Split(' ');
            // string[] sentence = new string[] {};
            // for (int i =0; i < words.Length; i++)
            // {
            //     upperCaseWords[i] = words[i].ToUpper();
            // }
            // string upperCaseWords = string.Join(' ', upperCaseWords);

            return firstVowel.ToString();
            return word;
        }
    }
}