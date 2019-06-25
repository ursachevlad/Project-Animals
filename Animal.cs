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
        protected int age;
        protected string sound;

        public Animal() { }

        public Animal(string parName, int parAge, string parSound)
        {
            this.name = parName;
            this.legs = parAge;
            this.sound = parSound;
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int Age
        {
            get { return age; }
            set { age = value; }
        }

        public string Sound
        {
            get { return sound; }
            set { sound = value; }
        }

        public void Description()
        {
            Console.WriteLine(name + "has" + age + "years and makes" + sound);
        }

        public virtual void Behaviour()
        {
            Console.WriteLine(name + "has a" + Behaviour);
        }

    }
}
