using System;

namespace YourFavoriteThings.Favorite
{
    class Pizza
    {
        public string Name { get; set; }

        public int Pieces { get; set; }

        public PizzaSauce Sauce { get; set; }

        public Pizza(string name, int pieces)
        {
            Name = name;
            Pieces = pieces;
            Console.WriteLine($"I ate {pieces} pieces of {name}.");

        }

        public void MakePizza()
        {
            Console.WriteLine($"The {Name} has a {Sauce} on it.");

        }
        public void Crust(string typeOfCrust)
        {
            Console.WriteLine($"{Name} is best on {typeOfCrust} crust");
        }

        public void Drink(string typeOfDrink)
        {
            Console.WriteLine($"{Name} is best with {typeOfDrink}.");

        }

    }  

enum PizzaSauce
        {
            Garlic,
            Red,
            White,
            Alfredo,
            Cheese,
            SpeciaqlSauce,
            BBQSauce
        }




    }

