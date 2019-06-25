using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectAnimals
{
    class Donkey : Animal
    {
        public Donkey(string parName, int parAge, string parSound) : base(parName, parAge, parSound)
        {

        }

        public override void Behaviour()
        {
            Console.WriteLine("Donkey behaviour is to make noise sounds");
        }
    }
}
