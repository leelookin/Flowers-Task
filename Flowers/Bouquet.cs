using System;
using System.Collections.Generic;
using System.Text;

namespace Flowers
{
    public class Store //: IEnumerable<Flower> 
    {
      public List<Flower> Buquet { get; set; }

        public Store()
        {
            Buquet = new List<Flower>();
        }

        public int GetPrice()
        {
            //foreach boquet
            // price = price + FlowerPrice
            // return price

            return 0;
        }
    }
}
