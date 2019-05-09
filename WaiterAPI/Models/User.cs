using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace WaiterAPI.Models
{
    public class User
    {
        [Key]
        public int userID { get; set; }
        public string username { get; set; }
        public string password { get; set; }
    }
}
