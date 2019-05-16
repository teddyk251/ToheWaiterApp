using System;
using System.Collections.Generic;
using System.Text;
using WaiterApp.Models;

namespace WaiterApp.Services
{
    public class DrinksService
    {
        public List<Drinks> GetDrinks()
        {
            var list = new List<Drinks>
            {
                new Drinks
                {
                    Name   = "Soft Drinks",
                    ImgUrl = "cold_drink.png"
                },
                new Drinks
                {
                    Name   = "Juices",
                    ImgUrl = "juice2.jpg"
                },
                new Drinks
                {
                    Name   = "Alcoholic Beverages",
                    ImgUrl = "alcoholic_beverage2.png"
                }


            };
            return list;
        }
    }
}
