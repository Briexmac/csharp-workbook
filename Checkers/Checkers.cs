// using System;
// using System.Collections.Generic;
// using System.Linq;

// namespace Checkers
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             int[][] whitePositions = new int[][] {
//                 new int[] { 0, 1 }, new int[] { 0, 3 }, new int[] { 0, 5 }, new int[] { 0, 7 },
//                 new int[] { 1, 0 }, new int[] { 1, 2 }, new int[] { 1, 4 }, new int[] { 1, 6 },
//                 new int[] { 2, 1 }, new int[] { 2, 3 }, new int[] { 2, 5 }, new int[] { 2, 7 }
//             };
            

//             int[][] blackPositions = new int[][] {
//                 new int[] { 5, 0 }, new int[] { 5, 2 }, new int[] { 5, 4 }, new int[] { 5, 6 },
//                 new int[] { 6, 1 }, new int[] { 6, 3 }, new int[] { 6, 5 }, new int[] { 6, 7 },
//                 new int[] { 7, 0 }, new int[] { 7, 2 }, new int[] { 7, 4 }, new int[] { 7, 6 }
//             };

//             Board board = new Board();
            
//             for (int i = 0; i < 12; i++)
//             {
//                 Checker white = new Checker("white", whitePositions[i]);
//                 Checker black = new Checker("black", blackPositions[i]);
//                 board.Checkers.Add(white);
//                 board.Checkers.Add(black);
//             }
//             board.DrawBoard();
//             Console.WriteLine("hello, world");
//         }
//     }

//     public class Checker
//     {
//         public string Symbol  { get; set; }
//         public int[] Position  { get; set; }
//         public string Color { get; set; }
        
//         public Checker(string color, int[] position)
//         {
//             int circleId;
//             if (color == "white")
//             {
//                 circleId = int.Parse("25CB", System.Globalization.NumberStyles.HexNumber);
//             }
//             else
//             {
//                 circleId = int.Parse("25CF", System.Globalization.NumberStyles.HexNumber);
//             }
//             this.Symbol = char.ConvertFromUtf32(circleId);
//             this.Position = position;
//         }
//     }

//     public class Board
//     {
//         public string[][] Grid  { get; set; }
//         public List<Checker> Checkers { get; set; }
        
//         public Board()
//         {
//             this.Checkers = new List<Checker>();
//             this.Grid = new string[][] { 
//                 new string[] {" ", " ", " ", " ", " ", " ", " ", " "},
//                 new string[] {" ", " ", " ", " ", " ", " ", " ", " "},
//                 new string[] {" ", " ", " ", " ", " ", " ", " ", " "},
//                 new string[] {" ", " ", " ", " ", " ", " ", " ", " "},
//                 new string[] {" ", " ", " ", " ", " ", " ", " ", " "},
//                 new string[] {" ", " ", " ", " ", " ", " ", " ", " "},
//                 new string[] {" ", " ", " ", " ", " ", " ", " ", " "},
//                 new string[] {" ", " ", " ", " ", " ", " ", " ", " "},
//             };
            
//             return;
//         }
        
//         public void CreateBoard()
//         {
//             // Your code here
//             return;
//         }
        
//         public void GenerateCheckers()
//         {
//             // Your code here
//             return;
//         }
        
//         public void PlaceCheckers()
//         {
//             foreach (var checker in Checkers)
//             {
//                 this.Grid[checker.Position[0]][checker.Position[1]] = checker.Symbol;
//             }
//             return;
//         }
        
//         public void DrawBoard()
//         {
//             PlaceCheckers();
//             Console.WriteLine("  0 1 2 3 4 5 6 7");
//             for (int i = 0; i < 8; i++)
//             {
//                 Console.WriteLine(i + " " + String.Join(" ", this.Grid[i]));
//             }
//             return;
//         }
        
//         public Checker SelectChecker(int row, int column)
//        {
//            return Checkers.Find(x => x.Position.SequenceEqual(new List<int> { row, column }));
//         }
        
//         public void RemoveChecker(int row, int column)
//         {
//             // Your code here
//             return;
//         }
        
//         public bool CheckForWin()
//         {
//            return Checkers.All(x => x.Color == "white") || !Checkers.Exists(x => x.Color == "white");
//         }
//     }

//     class Game
//     {
//         public Game()
//         {
//             // Your code here
//         }
//     }
// }

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Program
{
    public static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;
        Game game = new Game();
        Console.ReadLine();
    }
}

public class Checker
{
    public string Symbol  { get; set; }
    public int[] Position  { get; set; }
    public string Color { get; set; }
    
    // Constructor
    public Checker(string color, int[] position)
    {
        Color = color;
        Position = position;

        //  Use unicode to represent the symbol'
        // when we print to the console
        Symbol = color == "white" ? "\u25cf": "\u25cb";
    }
}

public class Board
{
    public string[][] Grid { get; set; }
    public List<Checker> Checkers { get; set; }
    // variable

    // position of white checkers
    int[][] whitePosition = new int[][]
    {
        new int[] { 0, 1 },
        new int[] {0, 3 },
        new int[] {0, 5 },
        new int[] {0, 7 },
        new int[] {1, 0 },
        new int[] {1, 2 },
        new int[] {1, 4 },
        new int[] { 1, 6 },
        new int[] {2, 1 },
        new int[] {2, 3 },
        new int[] {2, 5 },
        new int[] {2, 7 },
    };

    // position of black checkers
    int[][] blackPosition = new int[][]
    {
       new int[] { 5, 0 },
       new int[] {5, 2 },
       new int[] {5, 4 },
       new int[] {5, 6 },
       new int[] {6, 1 },
       new int[] {6, 3},
       new int[] {6, 5},
       new int[] {6, 7},
       new int[] {7, 0},
       new int[] {7, 2},
       new int[] {7, 4},
       new int[] {7, 6}
    };

    public Board()
    {

        return;
    }
    
    public void CreateBoard()
    {
    
        Grid = new string[][]
        {
            new string[] { " ", " ", " ", " ", " ", " ", " ", " "},
            new string[] { " ", " ", " ", " ", " ", " ", " ", " "},
            new string[] { " ", " ", " ", " ", " ", " ", " ", " "},
            new string[] { " ", " ", " ", " ", " ", " ", " ", " "},
            new string[] { " ", " ", " ", " ", " ", " ", " ", " "},
            new string[] { " ", " ", " ", " ", " ", " ", " ", " "},
            new string[] { " ", " ", " ", " ", " ", " ", " ", " "},
            new string[] { " ", " ", " ", " ", " ", " ", " ", " "},
        };
        return;
    }
    
    public void GenerateCheckers()
    {
        // white=
        Checkers = new List<Checker>();
        for (var i = 0; i < whitePosition.Length; i++)
        {
            Checker checker = new Checker("white", whitePosition[i]);
            Checkers.Add(checker);
        }
        // black=
        for (var i = 0; i < blackPosition.Length; i++)
        {
            Checker checker = new Checker("black", blackPosition[i]);
            Checkers.Add(checker);

        }

        return;
    }
    
    public void PlaceCheckers()
    {
        foreach(var c in Checkers)
        {
            int[] position = c.Position; 
            Grid[position[0]][position[1]] = c.Symbol;
        }
        return;
    }
    
    public void DrawBoard()
    {
        //row
        Console.WriteLine("   0  1  2  3  4  5  6  7");
        for(int i = 0; i < Grid.Length; i++)
        {
            string row = $"{i} ";
            for(int q = 0; q < Grid[i].Length; q++)
            {
                row += $" {Grid[i][q]} ";
            }
            Console.WriteLine(row);
        }

    }
    
    public Checker SelectChecker(int row, int column)
    {
        return Checkers.Find(x => x.Position.SequenceEqual(new List<int> { row, column }));
    }
    
    public void RemoveChecker(int row, int column)
    {
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
        Board board = new Board();
        board.GenerateCheckers();
        board.CreateBoard();
        board.PlaceCheckers();

        do
        {
            board.DrawBoard();

            Console.WriteLine("'move' or 'remove' checker?");
            string input = Console.ReadLine();

            Console.WriteLine("Pick up checker ROW?");
            int row = int.Parse(Console.ReadLine());

            Console.WriteLine("Pick up checker COLUMN?");
            int column = int.Parse(Console.ReadLine());

            Checker selectedChecker = board.SelectChecker(row, column);

            if (input == "remove")
            {
                board.Checkers.Remove(selectedChecker);
            }
            else
            {
                Console.WriteLine("Place ROW?");
                row = int.Parse(Console.ReadLine());

                Console.WriteLine("Place Column?");
                column = int.Parse(Console.ReadLine());

                selectedChecker.Position = new int[] { row, column };
            }

            board.CreateBoard();
            board.PlaceCheckers();

        } while (!board.CheckForWin());

        if (board.CheckForWin())
        {
            if (board.Checkers.All(x => x.Color == "white"))
            {
                Console.WriteLine("White won!");
            }
            else
            {
                Console.WriteLine("Black won!");
            }
        } 


    }
}