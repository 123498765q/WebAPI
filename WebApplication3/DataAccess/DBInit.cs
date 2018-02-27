using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace WebApplication3.DataAccess
{
    public class DBInit : CreateDatabaseIfNotExists<DataContext>
    {
        protected override void Seed(DataContext context)
        {
            context.Persons.Add(new Models.Person()
            {
                Name = "Tomas",
                Age = 48
            });

            context.Persons.Add(new Models.Person()
            {
                Name = "Jonas",
                Age = 47
            });

            context.SaveChanges();
            base.Seed(context);

        }
    }
}