using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            // TODO Be sure to follow best practice when creating your classes

            // Create a class Animal
            // give this class 4 members that all Animals have in common


            // Create a class Bird
            // give this class 4 members that are specific to Bird
            // Set this class to inherit from your Animal Class

            // Create a class Reptile
            // give this class 4 members that are specific to Reptile
            // Set this class to inherit from your Animal Class




            /*Create an object of your Bird class
             *  give values to your members using the object of your Bird class
             *  
             * Creatively display the class member values 
             */
            Bird Peacock = new Bird()

            {
                Name = "Peacock",
                Color = "Blue",
                NumberOfLegs = 2,
                IsACarnivore = true,
                TypeOfBeak = "short",
                IsExtinct = false,
                HasFeathers = true,
                IsWarmBlooded = true,
            };
            Console.WriteLine($"{Peacock.Name} is a bright flourescent {Peacock.Color}");
            Console.WriteLine();

            /*Create an object of your Reptile class
             *  give values to your members using the object of your Reptile class
             *  
             * Creatively display the class member values 
             */
            Reptiles lizard = new Reptiles()

            {
                Name = "lizard",
                Color = "green",
                NumberOfLegs = 4,
                IsACarnivore = true,
                TypeOfScales = "granular",
                IsTrained = true,
                HasAnOwner = true,
                IsMultiColored = false,

            };
            Console.WriteLine($"{lizard.Name} is sometimes a pet or sometimes apart of the wild! A lizard has {lizard.NumberOfLegs} legs.");
            Console.WriteLine();
        }
    }
}
