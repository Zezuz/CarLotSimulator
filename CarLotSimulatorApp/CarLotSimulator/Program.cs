using System;

namespace CarLotSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO

            //Create a seperate class file called Car
            //Car shall have the following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable
            //Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise()
            //The methods should take one string parameter: the respective noise property

            //Base Constructor
            Car bmw = new Car();
            bmw.Year = 2016;
            bmw.Make = "BMW";
            bmw.Model = "325i";
            bmw.EngineNoise = "RRMmmmrrrr";
            bmw.HonkNoise = "Beep";
            bmw.IsDriveable = true;

            //Object Initializer Syntax
            Car Octane = new Car { Year = 2015, Make = "Octane", Model = "Octane Rush", EngineNoise = "VROOM", HonkNoise = "Boop", IsDriveable = true };
            
            //
            Car Mustang = new Car();
            Mustang.Year = 2019;
            Mustang.Make = "Mustang";
            Mustang.Model = "Mach 1";
            Mustang.EngineNoise = "Brap";
            Mustang.HonkNoise = "Beep Bop";
            Mustang.IsDriveable = true;
            

            Console.WriteLine($"This car is a {Mustang.Year} {Mustang.Make}  and it's a {Mustang.Model}." );
            Mustang.MakeEngineNoise();
            Mustang.MakeHonkNoise();
            Console.WriteLine("");

            Console.WriteLine($"This car is a {Octane.Year} {Octane.Make} and it's a {Octane.Model}.");
            Octane.MakeEngineNoise();
            Octane.MakeHonkNoise();
            Console.WriteLine("");

            Console.WriteLine($"This car is a {bmw.Year} {bmw.Make} and it is a {bmw.Model}.");
            bmw.MakeEngineNoise();
            bmw.MakeHonkNoise();
            Console.WriteLine("");


            //Now that the Car class is created we can instanciate 3 new cars
            //Set the properties for each of the cars
            //Call each of the methods for each car

            //*************BONUS*************//

            // Set the properties utilizing the 3 different ways we learned about, one way for each car

            //*************BONUS X 2*************//

            //Create a CarLot class
            //It should have at least one property: a List of cars
            //Instanciate the a Carlot at the beginning of the program and as you create a car add the car to the list.
            //At the end iterate through the list printing each of car's Year, Make, and Model to the console
        }
    }
}
