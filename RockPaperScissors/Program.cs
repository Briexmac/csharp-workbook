using System;

namespace RockPaperScissors
{
    class Program
    {
        public static int hand1Score = 0;
        public static int hand2Score = 0;
        public static void Main()

        {
            while(hand1Score <5 && hand2Score <5)
            {
                Console.WriteLine("Enter hand 1:");
                string hand1 = Console.ReadLine().ToLower();
                string hand2 = "";
                Console.WriteLine(CompareHands(hand1, hand2));
                Console.WriteLine("you have {0} points and the computer has {1} points", hand1Score, hand2Score);
                
                Random compchoice = new Random();
                int x = compchoice.Next(0,3);
                
                
                if (x == 0)
                {

                    hand2 = "Rock";
                }
                if (x == 1)
                {
           
                    hand2 = "Paper";
                }
                if (x == 2)
                {
             
                    hand2 = "Scissors";
                }

        }
        }
        
        public static string CompareHands(string hand1, string hand2)
        {
    

            if (hand1 == hand2)
            {
                Console.WriteLine("It's a tie.");
            }

            else if (hand1 == "rock")
            {
                 if (hand2 == "paper")
                {
                    hand2Score++;
                    Console.WriteLine("computer wins.");
                    
                }
                else 
                {
                    hand1Score++;
                    Console.WriteLine("you win!");
                }
            }
            else if (hand1 == "paper")
            {
                if (hand2 == "rock")
                {
                    hand1Score++;
                    Console.WriteLine("you win!");
                }
                else 
                {
                    hand2Score++;
                    Console.WriteLine("computer wins.");
                }
            }
            else if (hand1 == "scissors")
            {  
                if (hand2 == "rock")
                {
                    hand2Score++;
                    Console.WriteLine("computer wins.");
                }
                else
                {
                    hand1Score++;
                    Console.WriteLine("you win.");
                }
            
            }
            return hand1 + ' ' + hand2;

        }
    }
}