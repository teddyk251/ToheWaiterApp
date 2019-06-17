using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace WaiterAPI.Models
{
    public class LineItem
    {
        [Key]
        public string Code { get; set; }
        
        //public string Element { get; set; }
        public string UnitAmount { get; set; }
        public int Quantity { get; set; }
        public decimal TotalAmount { get; set; }
        public string TaxType { get; set; }
        public decimal TaxAmount { get; set; }
        public decimal Cost { get; set; }
        public string Remark { get; set; }

        [ForeignKey("ElementCode")]
        public string ElementCode { get; set; }
        public virtual Element element { get; set; }

        [ForeignKey("VEcode")]
        public string VEcode { get; set; }
        public virtual VoucherExtensionRestaurant VoucherExtension { get; set; }

        [ForeignKey("VoucherCode")]
        public string VoucherCode { get; set; }
        public virtual Voucher voucher { get; set; }
    }
}
