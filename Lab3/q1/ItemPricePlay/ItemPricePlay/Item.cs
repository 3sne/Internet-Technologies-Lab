using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ItemPricePlay
{

   // public delegate void priceChangedEventHandler();
    class Item
    {
        //public event priceChangedEventHandler event1;
        public string itemName;
        public float itemPrice;
        public float ItemPrice
        {
            set
            {
                this.itemPrice = value;
                priceChange();
            }
            get
            {
                return this.itemPrice;
            }
        }

        public void priceChange()
        {
            Console.WriteLine(itemName + "'s price changed! New price is >> " + itemPrice);
        }

    }
}
