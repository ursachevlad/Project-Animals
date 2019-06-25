using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectAnimals
{
    class Lion : Animal
    {
        public Lion(string parName, int parAge, string parSound) : base(parName, parAge, parSound)
        {

        }

        public override void Behaviour()
        {
            Console.WriteLine("Lion behaviour is to rest much of his time");
        }
    }
}
