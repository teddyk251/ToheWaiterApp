using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace WaiterAPI.Models
{
    public class PhysicalTable
    {
        [Key]
        public string Code { get; set; }
        public string Description { get; set; }
        public string LocationCode { get; set; }
        public int MaxOccupancy { get; set; }
        public string RankCode { get; set; }
        public string Remark { get; set; }
    }
}
