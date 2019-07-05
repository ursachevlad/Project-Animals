using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectAnimals
{
    class Animal
    {
        protected string name;
        protected string sound;

        public Animal() { }

        public Animal(string parName, string parSound)
        {
            this.name = parName;
            this.sound = parSound;
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Sound
        {
            get { return sound; }
            set { sound = value; }
        }

        public void Description()
        {
            Console.WriteLine(name + "makes" + sound);
            Console.ReadKey();
        }
    }
}
