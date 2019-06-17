using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace WaiterAPI.Models
{
    public class User
    {
        [Key]
        public string Code { get; set; }
        public string username { get; set; }
        public string password { get; set; }
        
        public bool IsActive { get; set; }
        public int loggedInStatus { get; set; }

        [ForeignKey("PersonCode")]
        public string PersonCode { get; set; }
        public virtual Person person { get; set; }
    }
}
