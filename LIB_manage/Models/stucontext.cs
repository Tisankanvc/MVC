using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace LIB_manage.Models
{
    public class stucontext : DbContext
    {
        public DbSet<student> student { get; set; }
        public DbSet<book> Book { get; set; }
    }
}