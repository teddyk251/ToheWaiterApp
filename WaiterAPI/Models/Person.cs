using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace WaiterAPI.Models
{
    public class Person
    {
        [Key]
        public string PersonCode { get; set; }
        public string Type { get; set; }
        public string Title { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MiddleName { get; set; }
        public string Nationality { get; set; }
        public DateTime? DateOFBirth { get; set; }
        public string Gender { get; set; }
        public string Group { get; set; }
        public string Active { get; set; }
        public string Remark { get; set; }

    }
}
