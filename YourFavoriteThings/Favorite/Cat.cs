using System;
using System.Collections.Generic;
using System.Text;

namespace YourFavoriteThings.Favorite
{
    class Cat
    {
        public string Name { get; set; }

        public int Age { get; set; }

        public Cat(string name, int age)
        {
            Name = name;
            Age = age;
            Console.WriteLine($"{name} is {age} years old.");

        }
        public void Eats(string typeOfFood)
        {

            Console.WriteLine($"{Name} likes to eat {typeOfFood}.");
        }

        public void Plays(string typeOfPlay)
        {
            Console.WriteLine($"{Name} likes to play with {typeOfPlay}");
        }

        public void Eats()
        {
            Eats("Cat Food");
        }
        public void Plays()
        {
            Plays("Milk Cap");
        }
    }
}
