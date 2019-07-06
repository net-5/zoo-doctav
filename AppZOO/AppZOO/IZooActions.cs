using System;
using System.Collections.Generic;
using System.Text;

namespace AppZOO
{
    interface IZooActions
    {
        /// <summary>
        /// bring an animal from a source zoo to the current zoo
        /// </summary>
        /// <param name="pSourceZoo"></param>
        /// <param name="pAnimal"></param>
        void BringAnimal(Zoo pSourceZoo, Animal pAnimal);

        /// <summary>
        /// transfer an animal from the current zoo to a destination zoo
        /// </summary>
        /// <param name="pDestinationZoo"></param>
        /// <param name="pAnimal"></param>
        void TransferAnimal(Zoo pDestinationZoo, Animal pAnimal);

        /// <summary>
        /// a new animal is born in the current zoo
        /// </summary>
        /// <param name="pAnimal"></param>
        void BornNewAnimal(Animal pAnimal);
    }
}
