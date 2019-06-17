using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WaiterAPI.Models;

namespace WaiterAPI.ViewModels
{
    public class CartVM
    {
        public string cartID { get; set; }
        public string ElementCode { get; set; }
        //public string ElementDescription { get; set; }
        public string UnitAmount { get; set; }
        public int Quantity { get; set; }
        public decimal TotalAmount { get; set; }
        public decimal PriceValue { get; set; }
        //public bool IsDefault { get; set; }
        //public string Currency { get; set; }
        public string PhysicalTableCode { get; set; }
        public string UserCode { get; set; }
    }
}
