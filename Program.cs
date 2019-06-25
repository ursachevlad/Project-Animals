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
            hyena.Legs = 4;
            hyena.Description();
            hyena.Behaviour();

            Donkey donkey = new Donkey("Picasso", 4, "Iha Iha ha");
            donkey.Description();
            donkey.behaviour();

            Pony pony = new Pony("Spark", 4, "Mhaha ha");
            pony.Description();
            pony.behaviour();

            Horse horse = new Horse("Black Beauty", 4, "Mmmha Haa");
            horse.Description();
            horse.behaviour();

            Lion lion = new Lion("Simba", 4, "Waaaawwwwww");
            lion.Description();
            lion.behaviour();

            Console.ReadLine();
        }

        

    }
}
