using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectAnimals
{
    class Horse : Animal
    {
        public Horse(string parName, int parAge, string parSound) : base(parName, parAge, parSound)
        {

        }

        public override void Behaviour()
        {
            Console.WriteLine("Horse behaviour is to run");
        }
    }
}
