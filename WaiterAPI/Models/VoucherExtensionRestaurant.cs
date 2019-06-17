using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace WaiterAPI.Models
{
    public class VoucherExtensionRestaurant
    {
        [Key]
        public string VECode { get; set; }
        public string waiter { get; set; }
        public string PhysicalTableCode { get; set; }
        public string Remark { get; set; }
        

        [ForeignKey("VoucherCode")]
        public string VoucherCode { get; set; }
        public virtual Voucher voucher { get; set; }
    }
}
