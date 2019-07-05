using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectAnimals
{
    class Program
    {
        static void Main(string[] args)
        {
            Hyena hyena = new Hyena();
            hyena.Name = "Hyena";
            hyena.Sound = "Wawww";

            Donkey donkey = new Donkey();
            donkey.Name = "Figaro";
            donkey.Sound = "Ihaa Ihaaa";

            Pony pony = new Pony();
            pony.Name = "Spark";
            pony.Sound = "Mhaa mmmm";

            Horse horse = new Horse("");
            horse.Name = "Black Beauty";
            horse.Sound = "Mhaa Mhaa";

            Lion lion = new Lion("Simba", 4, "Waaaawwwwww");
            lion.Name = "Simba";
            lion.Sound = "Waawww";

            Console.ReadLine();
        }

        

    }
}
