using WaiterApp.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace WaiterApp.Services
{
    public class TabPageServices
    {
        public List<Tabpage> GetTabPages()
        {
            var list = new List<Tabpage>
            {
                new Tabpage
                {
                    catagori_name ="Main Dish"
                },
                new Tabpage
                {
                    catagori_name= "Drinks"
                }
            };
            return list;
        }

    }
}
