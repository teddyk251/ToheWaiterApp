using WaiterApp.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace WaiterApp.Services
{
    public class TabPageServices
    {
        public List<TabPage> GetTabPages()
        {
            var list = new List<TabPage>
            {
                new TabPage
                {
                    catagori_name ="Main Dish"
                },
                new TabPage
                {
                    catagori_name= "Drinks"
                }
            };
            return list;
        }

    }
}
