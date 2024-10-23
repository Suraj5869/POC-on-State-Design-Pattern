using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StateDesignDemo.Models
{
    internal class OutOfStockState:IState
    {
        public void BuyProduct(Ecommerce shop)
        {
            Console.WriteLine("Product is out of stock, buy some other product!!");
        }

        public void SelectProduct(Ecommerce shop)
        {
            Console.WriteLine("Product is out of stock.");
        }

        public void DispenseProduct(Ecommerce shop)
        {
            Console.WriteLine("No product to dispense. Selected product is out of stock.");
        }
    }
}
