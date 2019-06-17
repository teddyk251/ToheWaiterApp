using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
namespace WaiterAPI.Models
{
    public class Group
    {
        [Key]
        public string GroupCode { get; set; }
        public string Type { get; set; }
        public string Description { get; set; }
        public int Sequence { get; set; }
        public string Name { get; set; }
        public  bool IsActive { get; set; }
        public string Remark { get; set; }
        //add rk to itself
    }
}
