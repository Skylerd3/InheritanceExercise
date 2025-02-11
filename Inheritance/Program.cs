using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {


            var Crow = new Bird();
            Crow.WingColor = "Purple";
            Crow.HasTalons = true;
            Crow.BeakLength = 2;
            Crow.CanFly = true;


            var Alligator = new Reptile()
            {
                IsCooldBlooded = true,
                HasTail = true,
                CanGrowTailBack = false,
                IsScaly = true,

            };
            var MyAnimals = new Animal[] { Crow, Alligator, };

            foreach (var Animal in MyAnimals)
            {
                
                Console.WriteLine($"Age:{Animal.Age} years old");
                Console.WriteLine($"NumOfLegs:{Animal.NumOfLegs}");
                Console.WriteLine($"Color:{Animal.Age}");
                Console.WriteLine($"CanSwim:{Animal.Age}");
                Console.WriteLine();
                
            }
         



            // TODO Be sure to follow best practice when creating your classes

            //Done -- Create a class Animal
            // give this class 4 members that all Animals have in common


            // Done -- Create a class Bird
            // give this class 4 members that are specific to Bird
            // Set this class to inherit from your Animal Class

            // Done  --  Create a class Reptile
            // give this class 4 members that are specific to Reptile
            // Set this class to inherit from your Animal Class




            /*Create an object of your Bird class
             *  give values to your members using the object of your Bird class
             *  
             * Creatively display the class member values 
             */

            /*Create an object of your Reptile class
             *  give values to your members using the object of your Reptile class
             *  
             * Creatively display the class member values 
             */
        }
    }
}
