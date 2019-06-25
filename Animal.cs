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
        protected string food;

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

        public string Food
        {
            get { return food; }
            set { food = value; }
        }

        public void Description()
        {
            Console.WriteLine(name + "has" + age + "years and eats" + food);
        }
            
    }
}
