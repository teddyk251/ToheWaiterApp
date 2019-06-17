using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WaiterAPI.ViewModels
{
    public class ItemViewModel
    {
        //public string ElementCode { get; set; }
        public string Type { get; set; }
        public string PriceDescription { get; set; }
        public string ItemDecription { get; set; }
        public decimal PriceValue { get; set; }
        public bool IsDefault { get; set; }
        public string Currency { get; set; }
    }
}
