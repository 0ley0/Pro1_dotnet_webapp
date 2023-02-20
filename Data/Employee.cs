using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using MySql.Data;

namespace Blazorweb.Data 
{
    public class Employee 
    {
        [Key]
        public int id { get; set; }
        public string? email { get; set; }
        public string? password { get; set; }
        public string? fname { get; set; }
    }
}