using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace WaiterAPI.Models
{
    public class Element
    {
        [Key]
        public string ElementCode { get; set; }
        public string Type { get; set; }
        public string Description { get; set; }
        
        public string UOM { get; set; }
        public bool IsActive { get; set; }
        public string Remark { get; set; }

        [ForeignKey("GroupCode")]
        public string GroupCode { get; set; }
        public virtual Group group { get; set; }

        //[ForeignKey("Pricecode")]
        //public string Pricecode { get; set; }
        //public virtual price price { get; set; }
    }
}
