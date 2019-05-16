using WaiterApp.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace WaiterApp.Services
{
    public class TableServices
    {
        public List<Tables> GetTables()
        {
            var list = new List<Tables>
            {
                new Tables
                {
                    Table_Number = 1,
                    Table_Type= " Not Reserved"
                },

                new Tables
                {
                    Table_Number = 2,
                    Table_Type= " Not Reserved"
                },
                new Tables
                {
                    Table_Number = 3,
                    Table_Type= " Not Reserved"
                },

                new Tables
                {
                    Table_Number = 4,
                    Table_Type= " Not Reserved"
                },

                new Tables
                {
                    Table_Number = 5,
                    Table_Type= " Not Reserved"
                },
                new Tables
                {
                    Table_Number = 6,
                    Table_Type= " Not Reserved"
                },

                new Tables
                {
                    Table_Number = 7,
                    Table_Type= " Not Reserved"
                },

                new Tables
                {
                    Table_Number = 8,
                    Table_Type= " Not Reserved"
                },
                new Tables
                {
                    Table_Number = 9,
                    Table_Type= " Not Reserved"
                },

                new Tables
                {
                    Table_Number = 10,
                    Table_Type= " Not Reserved"
                },

                new Tables
                {
                    Table_Number = 11,
                    Table_Type= " Not Reserved"
                },
                new Tables
                {
                    Table_Number = 12,
                    Table_Type= " Reserved"
                }


            };
            return list;
        }
    }
}
