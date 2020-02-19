using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LIB_manage.Models
{
    public class book
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.None)]
        public String Book_Id { get; set; }
        public String Booka_Name { get; set; }
        public String ISBN { get; set; }
        public String Author { get; set; }
        public String Description { get; set; }
    }
}