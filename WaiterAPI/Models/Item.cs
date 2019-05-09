using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace WaiterAPI.Models
{
    public class Item
    {
        [Key]
        public int ItemID { get; set; }
        public int CategoryID { get; set; }
        public string ItemName { get; set; }
        public decimal ItemPrice { get; set; }

        [ForeignKey("CategoryID")]
        public virtual Category category { get; set; }
    }
}
