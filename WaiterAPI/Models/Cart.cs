using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace WaiterAPI.Models
{
    public class Cart
    {
        [Key]
        public int CartID { get; set; }
        public int ItemID { get; set; }
        public int TableNumber { get; set; }


        [ForeignKey("ItemID")]
        public virtual Item item { get; set; }
    }
}
