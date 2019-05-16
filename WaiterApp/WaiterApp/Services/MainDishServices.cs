using System;
using System.Collections.Generic;
using System.Text;
using WaiterApp.Models;

namespace WaiterApp.Services
{
    public class MainDishServices
    {
        public List<MainDish> GetMainDish()
        {
            var list = new List<MainDish>
            {
                new MainDish
                {
                    Name = "Doro Wet"                    
                },

                new MainDish
                {
                Name = "Kitfo"                
                }

            };
            return list;
        }
    }
}
