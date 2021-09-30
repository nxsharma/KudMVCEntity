using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace KudMVCEntityDemo.Models
{
    public class DepartmentTotals
    {
        [Key]
        public int id { get; set; }
        public string Name { get; set; }
        public int Total { get; set; }
    }
}