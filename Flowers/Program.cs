using System;
using System.Collections.Generic;

namespace Flowers
{
    class Program
    {
        public static double overalPrice;

        static void Main(string[] args)
            
        {
            var store = new Store();

            var rose1 = new Rose(name: "Belarusian Rose", height: 120, color: "Red", leaf: "With leaf", price: 10, pricle:"Yes");
            var rose2 = new Rose(name: "Spain Rose", height: 170, color: "Yellow", leaf: "Without leaf", price: 30, pricle: "No");
            var tulip1 = new Tulip(name: "Benjamin Tulip", height: 40, color: "Red", leaf: "With leaf", price: 3);

            store.Buquet.Add(rose1);
            store.Buquet.Add(rose2);
            store.Buquet.Add(tulip1);

            foreach(var k in store.Buquet)
            {
                Console.WriteLine(k.Name);
            }

            overalPrice = rose1.Price + rose2.Price + tulip1.Price;

            //Console.WriteLine(rose1.ToString());
            //Console.WriteLine(rose2.ToString());
            //Console.WriteLine(tulip1.ToString());
            //Console.WriteLine("Total price = " + overalPrice);
            Console.ReadLine();
        }

        /*public static void MakeBouquet()
        {
            Console.WriteLine("Do you need to make a bouquet?");
            var key = Console.ReadLine();
            if (key.ToUpper() == "Y".ToUpper())
            {
               
            }
           
        }*/
    }
} 