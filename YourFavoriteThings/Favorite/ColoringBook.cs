using System;
using System.Collections.Generic;
using System.Text;

namespace YourFavoriteThings.Favorite
{
    class ColoringBook
    {
        public string Name { get; set; }

        public int Pages { get; set; }

        public ColoringBook(string name, int pages)
        {
            Name = name;
            Pages = pages;
            Console.WriteLine($"{name} has {pages} pages.");

        }

        public void Picture(string typeOfPicture)
        {

            Console.WriteLine($"{Name} has a  {typeOfPicture} that I can't wait to color.");
        }

        public void Colors(string typeOfColors)
        {
            Console.WriteLine($"{Name} would look good colored with  {typeOfColors}");
        }
    }
}
