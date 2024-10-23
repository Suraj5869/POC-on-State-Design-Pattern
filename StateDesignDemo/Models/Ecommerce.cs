using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StateDesignDemo.Models
{
    internal class Ecommerce
    {
        private IState _currentState;

        public Ecommerce()
        {
            _currentState = new OutOfStockState();
        }

        public void SetState(IState state)
        {
            _currentState = state;
        }

        public void BuyProducts()
        {
            _currentState.BuyProduct(this);
        }

        public void SelectProducts()
        {
            _currentState.SelectProduct(this);
        }

        public void DispenseProducts()
        {
            _currentState.DispenseProduct(this);
        }

        public void Refill()
        {
            Console.WriteLine("Product Stock is refilled");
            SetState(new HasProductState());
        }
    }
}
