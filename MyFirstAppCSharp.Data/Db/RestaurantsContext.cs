using Microsoft.EntityFrameworkCore;
using MyFirstAppCSharp.Data.ModelRestau;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstAppCSharp.Data.Db {
    public class RestaurantsContext : DbContext {

        public DbSet<Grade> Grades { get; set; }

        public DbSet<Restaurant> Restaurants { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) {
            // c'est une mauvaise pratique que nous corrigerons ultérieurement
            optionsBuilder.UseSqlServer(
               @"server=.\SQL2017;database=myDbB32020;trusted_connection=true;");
        }



    }
}
