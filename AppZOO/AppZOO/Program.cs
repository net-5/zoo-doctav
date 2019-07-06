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

            zoo2.BornNewAnimal(animal1);
            zoo2.BornNewAnimal(animal2);

            //let's feed the animals
            animal1.Eat();
            animal2.Eat();

            //let's see the list of the animals from Cracovia zoo
            zoo2.PrintAnimalList();

            //let's transfer some animal from Cracovia to Birlad
            zoo2.TransferAnimal(zoo1, animal1);
            //let's see the list of the animals from Birlad zoo
            zoo2.PrintAnimalList();
            //and from Cracovia zoo
            zoo1.PrintAnimalList();

            //let's bring an animal to Birlad from Cracovia
            zoo1.BringAnimal(zoo2, animal2);
            //let's see the final lists of the animals
            zoo1.PrintAnimalList();
            zoo2.PrintAnimalList();
        }
    }
}
