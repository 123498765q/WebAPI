using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using WebApplication3.Models;

namespace WebApplication3.DataAccess
{
    public class DataContext : DbContext
    {
        //kom
        public DataContext() : base("name=DataContext")
        {
            Database.SetInitializer(new DBInit());
            Database.Initialize(true);
        }

        public DbSet<Person> Persons { get; set; }
    }
}