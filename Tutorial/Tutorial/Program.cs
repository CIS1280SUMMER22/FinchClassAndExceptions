using System;

namespace Tutorial
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Animal.AnimalId = 1;

            Animal animal = new Animal();
            animal.Name = "Bob";
            try
            {
                animal.SetNumberOfLegs(4);
                Console.WriteLine("Number Of Legs " + animal.GetNumberOfLegs());
            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e.Message);
            }

            animal.Sound = "Roar";
            animal.MakeSound();
            Console.WriteLine("Animal ID: " + animal.Id);

            try
            {
                int.Parse("2");
            }
            catch (FormatException e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.WriteLine("Finally");
            }


            Animal animalTwo = new Animal(2, "Billy", "Meow");
            Console.WriteLine("Number Of Legs " + animalTwo.GetNumberOfLegs());
            Console.WriteLine("Animal ID: " + animalTwo.Id);
        }
    }
}
