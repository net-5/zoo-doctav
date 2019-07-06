using System;
using System.Collections.Generic;
using System.Text;

namespace AppZOO
{
    interface IZooActions
    {
        void BringToZoo(Zoo pSourceZoo, Animal pAnimal);
        void TransferFromZoo(Zoo pDestinationZoo, Animal pAnimal);
        void BornNewAnimal(Animal pAnimal);
    }
}
