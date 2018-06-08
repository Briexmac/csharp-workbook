using System;
using System.Threading;

namespace DataTypes
{
    class Program
    {
        static void Main(string[] args)
        {
              //Variables//
            string sword = "";
            string stone = "";
            string creature ="";
            string fight ="";
            string walk ="";
            
           
            //Start program//
           Console.WriteLine("Welcome to the scary forest!");
           Thread.Sleep(5000); 
           Console.WriteLine();
           Console.WriteLine("You enter the forest because you are curious. With the faint light from the entrace you see a small glimmer from an object on the floor do you pick it up? y or n?");
           //flint choice//
           stone = Console.ReadLine();
           if (stone == "y")
           {
               Console.WriteLine("You reach down and find a stone. You hold onto this as it could possibly used as a weapon.");
           }
            else if (stone == "n")
            {
                Console.WriteLine("Not wanting to touch something you can't see clearly you move on.");
            }
          Thread.Sleep(3000);
          Console.WriteLine("As you move further your toes touch something on the floor do you pick it up? y or n?");
           sword = Console.ReadLine();
           // torch choice//
           if (sword == "y")
           {
               Console.WriteLine("You reach down and pick up the object, as you feel the object you realize it is a torch. Lit or not you can use this as a weapon.");
           }
            else if (sword == "n")
            {
                Console.WriteLine("Not wanting to touch something you can't see clearly you move on.");
            }
            Thread.Sleep(3000);
                //flint + torch = light//
               if (sword == "y" & stone == "y")
           {
               Console.WriteLine();
               Console.WriteLine("You are ready to Fight!");
               walk = "y";
           }
            else if (sword == "n" || stone == "n")
            {   
                Console.WriteLine();
                Console.WriteLine("You keep going into the dark.");
            }
            //creature encounter//
            Thread.Sleep (3000);
            Console.WriteLine();		
            Console.WriteLine("As you continue into the forest you see a faint glowing object at the edge of the woods.");
            Console.WriteLine();
            Thread.Sleep (3000);
            Console.WriteLine("Do you approach the glowing object? [y/n]: ");
            creature = Console.ReadLine();

            if (creature == "y")
                
            {
                Console.WriteLine();
                Thread.Sleep (3000);
                Console.WriteLine("As you move closer you realize that the glowing object is an enourmous eye.");
                Console.WriteLine();
                Thread.Sleep (3000);
                Console.WriteLine("You are now face to face with a gigantic creature!");
            }
            
            else if (creature == "n")
            {
                Console.WriteLine();
                Console.WriteLine("You try to slip by the object without disturbing it, as you slip by you notice the object starts to move!");
                Console.WriteLine();
                Thread.Sleep (3000);
                Console.WriteLine("The glowing object turns to you! You realize you're staring into the eye of a gigantic creature!");
                Thread.Sleep (3000);
            }

            Console.WriteLine();
            Thread.Sleep (3000);
            Console.WriteLine("Your first instinct is to run for yor life, do you turn and fight the creature instead?  y/n");
            fight = Console.ReadLine();
            //fight is unavoidable//
            //with lit torch odds are better//
            if (fight == "y" & walk =="y")
            {
                Random r = new Random();
                int number = r.Next(3, 10);

                if (number < 4)
                {
                    Console.WriteLine("You thrust feebly at the creature but miss and stumble forward. The creature pounces and sinks it's fangs into your back, you lay paralzyed and await death.");
                    Console.WriteLine();
                }
                else if (number < 7)
                {   Thread.Sleep (3000);
                    Console.WriteLine("You fight the creature valiantly but you just don't have a good enough weapon.  Eventually the creature wears you down and grabs you, it then begins wrapping you in it's deathly grip");
                    Console.WriteLine();
                }
                else if (number < 9)
                {   Thread.Sleep (3000);
                    Console.WriteLine("You get a clean strike at the creatures neck you hear a nice sizzle the creature shrieks and runs away!");
                    Console.WriteLine();
                }   
                else 
                {   Thread.Sleep (3000);
                    Console.WriteLine("You get a perfect strike and puncture the creatures neck and it shirvelled up and died. There is a nice pile of loot that the creature dropped from it's previous victims. Your pockets are filled with gold and jewels as you escape the forest!");
                    Console.WriteLine();
                }
                   
            }
            else if (fight == "y" || walk == "n")
            {
                Random r = new Random();
                int number = r.Next(1, 9);

                if (number < 4)
                {   Thread.Sleep (3000);
                    Console.WriteLine("You thrust your weapon feebly in the dark at the creature but miss and stumble forward. The creature pounces and sinks it's fangs into your back, you lay paralzyed and await death.");
                    Console.WriteLine();
                }
                else if (number < 7)
                {   Thread.Sleep (3000);
                    Console.WriteLine("You fight the spider valiantly but you just don't have a good enough weapon.  Eventually the creature wears you down and grabs you, it then begins wrapping you in it's dealthy grip");
                    Console.WriteLine();
                }      
         
                else if (number < 9)
                {   Thread.Sleep (3000);
                    Console.WriteLine("You get a clean strike at the creature eye and it shrieks and runs away!");
                    Console.WriteLine();
                }
                    
                else 
                {   Thread.Sleep (3000);
                    Console.WriteLine("You get a perfect strike and puncture the creatures neck and it shirvelled up and died. There is a nice pile of loot that the creature dropped from it's previous victims. Your pockets are filled with gold and jewels as you escape the forest!");
                    Console.WriteLine();
                }
                   
                   
            }
            //running is certain death//
            else if (fight == "n")
            {
                Console.WriteLine();
                Console.WriteLine("The creature is quicker than you and jumps on your back. You feel its fangs sink deep into you as you slowly die in agoninizing pain.");
                Console.WriteLine();
               
            }
            




        }
    }
}