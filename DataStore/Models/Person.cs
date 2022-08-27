using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStore.Models
{
    class Person
    {
        [Key]
        public string name { get; set; }
        public string phone_number { get; set; }
    }
}
