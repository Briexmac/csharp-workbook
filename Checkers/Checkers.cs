using System;
using System.Collections.Generic;
using System.Linq;

namespace Checkers
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Hello World!");
        }
    }

    public class Checker
    {
        public string Symbol  
        { 
            get
            {
                return Symbol;
            } 
            set
            {
                Symbol = value;
            } 
        }
        public int[] Position  { get; set; }
        public string Color { get; set; }
        
        public Checker(string color, int[] position)
        {
            Color = color; 
            Position = position;
            if (Color == "white")
            {
                int openCircleId = int.Parse("25CB", System.Globalization.NumberStyles.HexNumber);
                string openCircle = char.ConvertFromUtf32(openCircleId);
                Symbol = openCircle;
            }
            else
            {
                int closedCircleId = int.Parse("25CF", System.Globalization.NumberStyles.HexNumber);
                string closedCircle = char.ConvertFromUtf32(closedCircleId);
                Symbol = closedCircle;
            }
        }
    }

    public class Board
    {
        private List<Checker> checkers = new List<Checker>();
        public static int[,] whitePosition = new int[12,2];
        private static int[,] blackPosition = new int[12, 2];


        public Board()
        {
         
            return;
        }
        
        public void CreateBoard()
        {
            // Your code here
            return;
        }
        
        public void GenerateCheckers()
        {
            // Your code here
            return;
        }
        
        public void PlaceCheckers()
        {
            // Your code here
            return;
        }
        
        public void DrawBoard()
        {
            // Your code here
            return;
        }
        
        public Checker SelectChecker(int row, int column)
        {
            return Checkers.Find(x => x.Position.SequenceEqual(new List<int> { row, column }));
        }
        
        public void RemoveChecker(int row, int column)
        {
            // Your code here
            return;
        }
        
        public bool CheckForWin()
        {
            return Checkers.All(x => x.Color == "white") || !Checkers.Exists(x => x.Color == "white");
        }
    }

    class Game
    {
        public Game()
        {
            // Your code here
        }
    }
}
