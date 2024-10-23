using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StateDesignDemo.Models
{
    internal interface IState
    {
        void BuyProduct(Ecommerce shop);
        void SelectProduct(Ecommerce shop);
        void DispenseProduct(Ecommerce shop);
    }
}
