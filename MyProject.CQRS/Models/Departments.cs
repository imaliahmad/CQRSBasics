using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace MyProject.CQRS.Models
{
    public class Departments
    {
        [Key]
        public int DeptId { get; set; }
        public string DName { get; set; }
    }
}
