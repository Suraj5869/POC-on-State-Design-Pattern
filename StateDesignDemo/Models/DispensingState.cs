using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;

namespace StateDesignDemo.Models
{
    internal class DispensingState:IState
    {

        public void BuyProduct(Ecommerce shop)
        {
            Console.WriteLine("Please wait, we're already dispensing your item.");
        }

        public void SelectProduct(Ecommerce shop)
        {
            Console.WriteLine("Item already selected, dispensing is in progress......");
        }

        public void DispenseProduct(Ecommerce shop)
        {
            Console.WriteLine("Dispensing item...");
            shop.SetState(new HasProductState());  
        }
    }
}
