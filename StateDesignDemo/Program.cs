using StateDesignDemo.Models;

namespace StateDesignDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("~~~~~~ POC on State Design Pattern ~~~~~~");

            //There are three states in our Ecommerce Shop
            //1. OutOfStock
            //2. HasProductState
            //3. DispensingState

            Ecommerce ecommerceShop = new Ecommerce();
            //Initially the state is OutOfStock

            ecommerceShop.SelectProducts();
            ecommerceShop.BuyProducts();
            ecommerceShop.DispenseProducts();

            //As we call the Refill method the state changes to HasProductState
            ecommerceShop.Refill();

            //The below methods are work as per HasProductState methods
            ecommerceShop.SelectProducts();

            ecommerceShop.BuyProducts();

            //As soon as we call the BuyProduct Method of HasProductState
            //it again change the state to HasProductState to DispensingState

            //Below methods are work as per DispensingState methods 
            ecommerceShop.SelectProducts();
            ecommerceShop.DispenseProducts();

            //The above method of DispensingState again change the state to HasProductState
            //Below method is call the HasProductState class method
            ecommerceShop.SelectProducts();

        }
    }
}
