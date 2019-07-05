using System;
using System.Collections.Generic;
using AnimalsProjectFinal.Farm;

namespace AnimalsProjectFinal.Actions
{
    public class AnimalsList
    {
        private List<Animal> animals;

        public AnimalsList()
        {
            animals = new List<Animal>();

            InitAnimals();
        }

        private void InitAnimals()
        {
            Duck donald = new Duck("Donald");
            Cat lizy = new Cat("Lizy");
            Dog rex = new Dog("Rex");
            Horse blackbeauty = new Horse("BlackBeauty");
            Turkey freebie = new Turkey("Freebie");

            animals.Add(donald);
            animals.Add(lizy);
            animals.Add(rex);
            animals.Add(blackbeauty);
            animals.Add(freebie);
        }

        public void ShowAnimals()
        {
            foreach (Animal animal in animals)
            {
                Console.WriteLine($"{animal.GetType().Name} {animal.Name} makes {animal.MakeSound()}!");
            }
        }
    }
}