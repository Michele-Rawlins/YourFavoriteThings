using System;
using YourFavoriteThings.Favorite;

namespace YourFavoriteThings
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to my Favorite Things!");
            var dog = new Dog("Roxie",4 );

            dog.Plays("ball");
            dog.Eats("whipped cream");

            var cat = new Cat("Cheetah", 15);

            cat.Plays("milk cap");
            cat.Eats("grass");

            var pizza = new Pizza("pizza", 2)
            {
                Sauce = PizzaSauce.Garlic,
            };
            

            pizza.Drink("beer");
            pizza.Crust("thin");
            pizza.MakePizza();

            var coloringBook = new ColoringBook("Fairy Tales", 22);

            coloringBook.Picture("Fairy");
            coloringBook.Colors("Reds");

        }
    }
}
