using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WaiterAPI.Models;
using WaiterAPI.ViewModels;
using WaiterAPI.DBContext;

namespace WaiterAPI.Repository
{
    public class AddToCart : IAddToCart
    {
        WaiterContext db = new WaiterContext();

        public AddToCart(WaiterContext db)
        {
            this.db = db;
        }
        public void addToCart(CartVM cart)
        {
            var cartItem = db.LineItems.FirstOrDefault(c => c.Code == cart.cartID && c.ElementCode == cart.ElementCode);
            VoucherExtensionRestaurant ve = new VoucherExtensionRestaurant();

            if(cartItem == null)
            {
                cartItem = new LineItem
                {
                    Code = cart.cartID,
                    ElementCode = cart.ElementCode,
                    UnitAmount = cart.UnitAmount,
                    Quantity = cart.Quantity,
                    TotalAmount = cart.TotalAmount,
                    TaxAmount = 0,
                    TaxType = null,
                    Remark = null,
                    Cost = cart.PriceValue * cart.Quantity,
                    VoucherCode = null

                };
                db.LineItems.Add(cartItem);
            }
            else
            {
                cartItem.Quantity++;
            }
            db.SaveChangesAsync();
        }
        public CartVM Getcart(string cartid)
        {
            var cart = db.LineItems.Where(x => x.Code == cartid).FirstOrDefault();
            if(cart != null)
            {
                CartVM cartVM = new CartVM
                {
                    cartID = cart.Code,
                    ElementCode = cart.ElementCode,
                    UnitAmount = cart.UnitAmount,
                    Quantity = cart.Quantity,
                    TotalAmount = cart.TotalAmount,
                    PriceValue = db.Prices.Where(c => c.ElementCode == cart.ElementCode).FirstOrDefault().PriceValue,
                    PhysicalTableCode = cart.VoucherExtension.PhysicalTableCode,
                    UserCode = cart.VoucherExtension.waiter
                };
                return cartVM;
            }
            else 
                return null;
        }
        
           
        
    }
}
