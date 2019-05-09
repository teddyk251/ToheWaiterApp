using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WaiterAPI.Models;
using WaiterAPI.DBContext;
namespace WaiterAPI.Repository
{
    public class SelectItem : ISelectItem
    {
        WaiterContext db = new WaiterContext();

        public SelectItem(WaiterContext db)
        {
            this.db = db;
        }
        public Item selectItem(int Itemid)
        {
            var item = db.Items.Where(c => c.ItemID == Itemid).FirstOrDefault();
            return item;
        }
    }
}
