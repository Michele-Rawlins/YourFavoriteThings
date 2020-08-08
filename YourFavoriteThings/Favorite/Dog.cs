using System;
using System.Collections.Generic;
using System.Text;

namespace YourFavoriteThings.Favorite
{
    class Dog
    {
        public string Name { get; set; }

        public int Age { get; set; }

        public Dog(string name, int age)
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
            Console.WriteLine($"{Name} likes to play {typeOfPlay}");
        }

        public void Eats()
        {
            Eats("Dog Food");
        }

        public void Plays()
        {
            Plays("Ball");
        }
    }
}
