using System;

namespace AppZOO
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello from the ZOO!");
            Zoo zoo1 = new Zoo("Birlad");
            Zoo zoo2 = new Zoo("Cracovia");

            //let's born some animals at Cracovia zoo  :))
            Animal animal1 = new Animal("Elefantel dragutzel", AnimalType.Elephant, DateTime.Now, Food.Milk);
            Animal animal2 = new Animal("Girafel lungutzel", AnimalType.Giraffe, DateTime.Now, Food.Grass);
            //let's see the list of the animals from Cracovia zoo
            zoo1.PrintAnimalList();
        }
    }
}
