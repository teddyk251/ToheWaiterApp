using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace WaiterAPI.Models
{
    public class ElementModifier
    {
        [Key]
        public string Code { get; set; }
        
        public string Description { get; set; }
        public string Remark { get; set; }

        [ForeignKey("ElementCode")]
        public string ElementCode { get; set; }
        public virtual Element element { get; set; }
    }
}
