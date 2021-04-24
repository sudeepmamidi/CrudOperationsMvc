using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace CrudOperationsMvc.Models
{
    public class CrudDbContext : DbContext
    {
        public CrudDbContext():base("Connection")
        {

        }

        public DbSet<User> Users { get; set; }
    }
}