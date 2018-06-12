using System;
using System.Collections.Generic;

namespace OOP
{
					
    public class Program
    {
        public static void Main()
        {
            List<Person> people1 = new List<Person>()
            { 
                new Person("Beckett"),
                new Person("Lee"),
                new Person("Benton")
            };
            List<Person> people2 = new List<Person>()
            { 
                new Person("James"),
                new Person("Max")
            };
            List<Person> people3 = new List<Person>()
            { 
                new Person("Chase"),
                new Person("Gary")
            };
            Car blueCar = new Car("blue", 5, people1);
            Console.WriteLine(blueCar.PeopleReport());
            blueCar.PutPeopleInCar(people2); 
            blueCar.PeopleReport();
            Car greyCar = new Car("grey", 2, people3);
            Garage smallGarage = new Garage(2);
            smallGarage.ParkCar(blueCar, 0);
            smallGarage.ParkCar(greyCar, 1);
            Console.WriteLine(smallGarage.Cars);
            Console.WriteLine("");
        }
    }

    class Car
    {
        private List<Person> people;
        
        public Car(string startColor, int size, List<Person> startPeople)
        {
            Color = startColor;
            Size = size;
            People = startPeople;
        }
        
        public string Color { get; private set; }

        public List<Person> People 
        { 
            get {
                return people;
            }
            private set {
                people = value;
            }
        }


        public int Size { get; private set; }

        public string PeopleReport()
        {
            string driverAndPassengers = $"\nPeople in {Color} car: ";
            for (int i = 0; i < People.Count; i ++)
            {
                if (people[i] != null)
                {
                    driverAndPassengers += People[i].Name;
                    if (i < people.Count - 1 && People[i + 1] != null)
                    {
                        driverAndPassengers += ", ";
                    }
                }
            }
            return driverAndPassengers;
        }

        public void PutPeopleInCar(List<Person> people)
        {
            for (int i = 0; i < people.Count; i ++)
            {
                if (People.Count < Size)
                {
                    People.Add(people[i]); 
                }
            }
        }
    }

    class Garage
    {
        private Car[] cars;
        
        public Garage(int startSize)
        {
            Size = startSize;
            this.cars = new Car[startSize];
        }
        
        public int Size { get; private set; }
        
        public void ParkCar (Car car, int spot)
        {
            cars[spot] = car;
        }
        
        public string Cars {
            get 
            {
                string report = "";
                for (int i = 0; i < cars.Length; i++)
                {
                    if (cars[i] != null) 
                    {
                        report += String.Format("\nThe {0} car is in spot {1}", cars[i].Color, i);
                        if (cars[i].People != null)
                        {
                            report += cars[i].PeopleReport() + "\n";
                        }
                    }
                }
                report += "\n--End of Report--";
                return report;
            }
        }
    }

    class Person
    {
        public Person(string name)
        {
            Name = name;
        }

        public string Name { get; private set; }
    }
}