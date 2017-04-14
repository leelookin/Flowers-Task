using System;
using System.Collections.Generic;
using System.Text;

namespace Flowers
{
    public class Flower
    {
        public string Name { get; set; }
        public double Height { get; set; }
        public string Color { get; set; }
        public string Leaf { get; set; }
        public double Price { get; set; }

        public override string ToString()
        {
            return string.Format("Name: {0}\nHeight: {1}\nColor: {2}\nLeaf: {3} \nPrice: {4}", Name, Height, Color, Leaf, Price);
        }

        public Flower()
        {
        }

        public Flower(string name, double height, string color, string leaf, double price)
        {
            Name = name;
            Height = height;
            Color = color;
            Leaf = leaf;
            Price = price;
        }
    }

}