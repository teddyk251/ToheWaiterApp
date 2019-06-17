using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WaiterAPI.Models;
using WaiterAPI.DBContext;
using System.Text;
namespace WaiterAPI.Repository
{
    public class SelectCategory : ISelectCategory
    {
        WaiterContext db = new WaiterContext();
        public SelectCategory(WaiterContext db)
        {
            this.db = db;
        }

        public List<Element> selectCatagory(string catID)
        {
            List<Element> items = new List<Element>();
            items = db.Elements.Where(u => u.GroupCode.Equals(catID)).ToList();
            
            return items;
        }
    }
}
