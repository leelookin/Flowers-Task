using System;
using System.Collections.Generic;
using System.Text;

namespace Flowers
{
     public class Rose : Flower
     {
        public string Pricle { get; set; }

        public Rose(string name, double height, string color, string leaf, double price, string pricle)
            : base(name, height, color, leaf, price)
        {
            Pricle = pricle;
        } 
        public void PricleWrite()
        {
            Console.WriteLine("Pricle:" + pricle);
        }
        
     }
}