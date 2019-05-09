using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WaiterAPI.Models;
using WaiterAPI.DBContext;

namespace WaiterAPI.Repository
{
    public class SelectCategory : ISelectCategory
    {
        WaiterContext db = new WaiterContext();
        public SelectCategory(WaiterContext db)
        {
            this.db = db;
        }

        public List<Item> selectCatagory(int catID)
        {
            List<Item> items = new List<Item>();
            items = db.Items.Where(u => u.CategoryID == catID).ToList();

            return items;
        }
    }
}
