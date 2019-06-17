using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WaiterAPI.ViewModels;

namespace WaiterAPI.Repository
{
    public interface IAddToCart
    {
        void addToCart(CartVM cart);
        CartVM Getcart(string cartid);
    }
}
