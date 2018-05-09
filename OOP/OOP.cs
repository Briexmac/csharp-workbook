using System;

namespace OOP
{
    class Program
    {
        static void Main()
        {
            Person rebel = new Person("Leia" , "Organa");
            Person imperial = new Person("Darth" , "Vader");
            Console.WriteLine("Hello World!");
        }
    }  
    class Person
    {
        private string firstName;
        private string lastName;
        private string password;
        public Person(string firstName, string lastName, string alliance)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.alliance = alliance;
        }
        public string FullName
        { 
            get {
                return this.firstName + " " + this.lastName; 
            }
            set {
                string[] names = value.Split(' ');                
                this.firstName = names[0];
                this.lastName = names[1];
            }
        } 
        class Ship
        {
            private Person[] passengers;

            public Ship(string alliance, string type, int size);
            {
                    this,type = type;
                    this.allaince = alliance;
                    this.passengers = new Person[size];
            }
            public string Type {get; set;}
            public string Alliance {get; set;}

            public string Passengers{
                get{
                    foreach (var person in passengers)
                    {
                        Console.WriteLine(String.Format("{0}", person.FullName));
                    }
                    return "That's Everybody!";
                }
            }
            public void EnterShip(Person person, int seat) 
            {
                this.Passengers [seat]
            } 
            public void ExitShip(int seat)
            {
                this.Passengers [seat] 
            }     

            class Station
            {

            }
    }
}
    