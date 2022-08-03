﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MVCEF.Models
{
    [Table("tblEmployee")]
    public class Employee
    {
        [Key]
        public int Eid { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public float Salary { get; set; }
        public string Address { get; set; }
    }
}
