using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LIB_manage.Models
{
    public class student
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.None)]
        public String ID { get; set; }
        public String Name { get; set; }
        [DataType(DataType.Password)]
        public String Password { get; set; }
    }
}