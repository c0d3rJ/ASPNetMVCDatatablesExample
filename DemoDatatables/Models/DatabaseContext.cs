using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace DemoDatatables.Models
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext() : base("DBConnection")
        {

        }
        public DbSet<Customers> Customers { get; set; }
    }
}