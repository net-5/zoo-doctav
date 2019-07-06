using System;
using System.Collections.Generic;
using System.Text;

namespace AppZOO
{
    class Zoo : IZooActions
    {
        private string zooName;
        private List<Animal> animals;

        public List<Animal> ListOfAnimals
        {
            get { return animals; }
            private set { animals = value; }
        }

        public string ZooName
        {
            get { return zooName; }
            private set { zooName = value; }
        }

        public Zoo(string pName)
        {
            ZooName = pName;
        }

        /// <summary>
        /// print the list of all the animals from the current zoo
        /// </summary>
        public void PrintAnimalList()
        {
            Console.WriteLine($"At the zoo {this.ZooName} there are the following animals:");
            foreach (Animal animal in this.ListOfAnimals)
            {
                Console.WriteLine(animal.AnimalInfo());
            }
            Console.WriteLine();
        }

        public void BornNewAnimal(Animal pAnimal)
        {
            this.ListOfAnimals.Add(pAnimal);
            Console.WriteLine($"The animal named {pAnimal.AnimalName} was borned at zoo {this.ZooName}");
        }

        public void BringToZoo(Zoo pSourceZoo, Animal pAnimal)
        {
            ListOfAnimals.Add(pAnimal);
            Console.WriteLine($"The animal named {pAnimal.AnimalName} was bring from zoo {pSourceZoo.ZooName}");
        }

        public void TransferFromZoo(Zoo pDestinationZoo, Animal pAnimal)
        {
            this.ListOfAnimals.Remove(pAnimal);
            pDestinationZoo.ListOfAnimals.Add(pAnimal);
            Console.WriteLine($"The animal {pAnimal.AnimalName} was transfered from {this.ZooName} to {pDestinationZoo.ZooName}");
        }
    }
}
