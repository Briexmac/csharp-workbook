using System;

namespace TicTacToe
{
    class Program
    {
        public static string playerTurn = "X";
        public static string[][] board = new string[][]
        {
            new string[] {" ", " ", " "},
            new string[] {" ", " ", " "},
            new string[] {" ", " ", " "}
        };

        public static void Main()
        {
            do
            {
                DrawBoard();
                GetInput();

            } while (!CheckForWin() && !CheckForTie());

            Console.ReadLine();
        }

        public static void GetInput()
        {
            Console.WriteLine();
            Console.WriteLine("Player " + playerTurn);
            Console.WriteLine("Enter Row:");
            int row = int.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("Enter Column:");
            int column = int.Parse(Console.ReadLine());
            PlaceMark(row, column);
            
            if (CheckForWin())
            {
                DrawBoard();
                Console.WriteLine();
                Console.WriteLine("Player " + playerTurn + "! You win!");
                return;
            }
            else if (CheckForTie())
            {
                DrawBoard();
                Console.WriteLine();
                Console.WriteLine("It's a tie.");
                return;
            }
            
            playerTurn = (playerTurn == "X") ? "O" : "X";
        }


        public static void PlaceMark(int row, int column)
        {
            // your code goes here
            board[row][column] = playerTurn;

            return;
        }

        public static bool CheckForWin()
        {
            // your code goes here
            if (HorizontalWin() || VerticalWin() || DiagonalWin())
            {
                return true;
            }
            return false;
        }

        
        public static bool HorizontalWin()
        {
            // your code goes here
            if (board[0][0] == playerTurn && board[0][1] == playerTurn && board[0][2] == playerTurn)
                return true;
            if (board[1][0] == playerTurn && board[1][1] == playerTurn && board[1][2] == playerTurn)
                return true;
            if (board[2][0] == playerTurn && board[2][1] == playerTurn && board[2][2] == playerTurn)
                return true;

            return false;
        }

        public static bool VerticalWin()
        {
            // your code goes here
            if (board[0][0] == playerTurn && board[1][0] == playerTurn && board[2][0] == playerTurn)
                return true;
            if (board[0][1] == playerTurn && board[1][1] == playerTurn && board[2][1] == playerTurn)
                return true;
            if (board[0][2] == playerTurn && board[1][2] == playerTurn && board[2][2] == playerTurn)
                return true;

            return false;
        }

        public static bool DiagonalWin()
        {
            // your code goes here
            if (board[0][0] == playerTurn && board[1][1] == playerTurn && board[2][2] == playerTurn)
                return true;
            if (board[0][2] == playerTurn && board[1][1] == playerTurn && board[2][0] == playerTurn)
                return true;

            return false;
        }

        public static bool CheckForTie()
        {
            // your code goes here
            for (int row = 0; row < 3; row++)
            {
                for (int column = 0; column < 3; column++)
                {
                    if (board[row][column] != "X" && board[row][column] != "O")
                        return false;
                }
            }
            return true;
        }

        public static void DrawBoard()
        {
            Console.WriteLine("  0 1 2");
            Console.WriteLine("0 " + String.Join("|", board[0]));
            Console.WriteLine("  -----");
            Console.WriteLine("1 " + String.Join("|", board[1]));
            Console.WriteLine("  -----");
            Console.WriteLine("2 " + String.Join("|", board[2]));
        }
    }
}