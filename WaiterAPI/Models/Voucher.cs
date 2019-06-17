using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace WaiterAPI.Models
{
    public class Voucher
    {
        [Key]
        public string VoucherCode { get; set; }
        public string Type { get; set; }
        public string VoucherTo { get; set; }
        public DateTime TimeStamp { get; set; }
        public double Amount { get; set; }
        public bool IsIssued { get; set; }
        public bool IsVoid { get; set; }
        public string Unit { get; set; }
        public string remark { get; set; }
    }
}
