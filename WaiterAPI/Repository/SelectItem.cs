using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WaiterAPI.Models;
using WaiterAPI.DBContext;
using WaiterAPI.ViewModels;
using System.Data.SqlClient;
namespace WaiterAPI.Repository
{
    public class SelectItem : ISelectItem
    {
        WaiterContext db = new WaiterContext();

        public SelectItem(WaiterContext db)
        {
            this.db = db;
        }
        public ItemViewModel selectItem(string Itemid)
        {
            //var item = db.Elements.Where(c => c.ElementCode == Itemid).FirstOrDefault();
            //return item;

            var temp = from temp1 in db.Elements
                       from temp2 in db.Prices
                       where temp1.ElementCode == Itemid
                       select new { Element = temp1, price = temp2 };
            var item = temp.FirstOrDefault();

            if (item != null)
            {
                ItemViewModel itemViewModel = new ItemViewModel();

                itemViewModel.Currency = item.price.Currency;
                itemViewModel.PriceDescription = item.price.Decription;
                itemViewModel.ItemDecription = item.Element.Description;
                itemViewModel.PriceValue = item.price.PriceValue;
                itemViewModel.Type = item.Element.Type;
                itemViewModel.IsDefault = item.price.IsDefault;

                return itemViewModel;
            }

            return null;
           
        }
    }
}
