using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StateDesignDemo.Models
{
    internal class HasProductState : IState
    {
        public void BuyProduct(Ecommerce shop)
        {
            Console.WriteLine("Product is ready to buy.");
            shop.SetState(new DispensingState());
        }

        public void SelectProduct(Ecommerce shop)
        {
            Console.WriteLine("Product Selected");
        }

        public void DispenseProduct(Ecommerce shop)
        {
            Console.WriteLine("Select a product first to dispense.");
        }

    }
}
