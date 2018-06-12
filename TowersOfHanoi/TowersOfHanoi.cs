using System;

namespace TowersOfHanoi
{
    class Program
    {

        static void Main(string[] args)
        {
            Disc five = new Disc(5);
            Disc ten = new Disc(10);
            Disc fifteen = new Disc(15);
            Disc twenty = new Disc(20); 
            Disc[] initialStack = { twenty, fifteen, ten, five };
            Stick rodOne = new Stick(initialStack, "1");
            Stick rodTwo = new Stick(new Disc[4], "2");
            Stick rodThree = new Stick(new Disc[4], "3");
            Stick fromStick = null;
            Stick toStick = null;

            Console.WriteLine("");
            rodOne.reportDiscs();
            rodTwo.reportDiscs();
            rodThree.reportDiscs();
            Console.WriteLine("");
            while (rodOne.WinFlag == false && rodTwo.WinFlag == false && rodThree.WinFlag == false)
            {
                Console.WriteLine("Move from? (Enter 1, 2 or 3)");
                string from = Console.ReadLine();
                Console.WriteLine("Move to? (Enter 1, 2 or 3)");
                string to = Console.ReadLine();
                Stick [] rods = { rodOne, rodTwo, rodThree };
                foreach (Stick stickin rods)
                {
                    if (stick.Number == from)
                    {
                       fromStick = stick; 
                    }
                    if (stick.Number == to)
                    {
                        toStick = stick;
                    }
                }
                if (fromStick != null && toStick != null)
                {
                    fromStick.checkAndMove(toStick);
                    fromStick = null;
                    toStick = null;
                }
                else
                {
                    Stick.printErrorMessage();        
                }
                rodOne.reportDiscs();
                rodTwo.reportDiscs();
                rodThree.reportDiscs();
                Console.WriteLine("");
            }
        }
    }

    class Stick 
    {
        public static void printErrorMessage()
        {
            Console.WriteLine("\nTry again!\n");
        }

        public Stick(Disc[] initialStack, string num)
        {
            Number = num;
            Stack = initialStack;
            WinFlag = false;
        }

        public string Number { get; private set; }

        public Disc[] Stack { get; private set; }

        public bool WinFlag { get; private set; }

        public void checkAndMove(Stick dest)
        { 
            if (this.Stack[0] != null)
            {
                Disc md = this.MoveDisc(dest);
                if (md != null)
                {
                    Console.WriteLine($"\nMoved size {md.Size} disc to stick{dest.Number}\n");
                    if (dest.checkForWin())
                    {
                        dest.WinFlag = true;
                    }
                    return;
                }
            }
            printErrorMessage(); 
        }

        private Disc MoveDisc(Stick dest)
        {
            Disc moved = new Disc(0);
            int i;
            for (i = Stack.Length - 1; i > -1; i --)
            {
                if (this.Stack[i] != null)
                {
                    moved = this.Stack[i];
                    this.Stack[i] = null;
                    break;
                }
            }
            if (dest.Stack[0] != null)
            {
                for (int j = this.Stack.Length - 1; j > -1; j --)
                {
                    if ((dest.Stack[j] != null && dest.Stack[j].Size > moved.Size))
                    {
                        return dest.Stack[j + 1] = moved;
                    }
                }
            }
            else
            {
                return dest.Stack[0] = moved;
            }
            
            // replace disc in its original position if move is invalid
            this.Stack[i] = moved;
            return null;
        }

        public void reportDiscs()
        {   
            Console.Write($"Stick {this.Number}: ");
            if (this.Stack[0] != null)
            {
                foreach (Disc disc in this.Stack)
                {
                    if (disc != null)
                    {
                        Console.Write($"{disc.Size} ");
                    }
                }
            }
        Console.WriteLine("");
        }


        public bool checkForWin()
        {
            if (this.Stack[this.Stack.Length - 1] != null)
            {
                Console.WriteLine("You win!\n");
                return true;
            }
            return false;
        }
    }

    class Disc 
    {
        public Disc(int size)
        {
            Size = size;
        }

        public int Size { get; private set; }

    }
}