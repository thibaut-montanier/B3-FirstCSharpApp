using Microsoft.EntityFrameworkCore;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyFirstAppCSharp.Data.Db;
using MyFirstAppCSharp.Data.ModelRestau;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyFirstAppCSharp.Data.Tests {

    [TestClass]
    public class DbTests {

        [TestMethod]
        public void CreateDbTest() {

            using(var db = new RestaurantsContext()) {
                db.Database.EnsureCreated();



                var Restau1 = new Restaurant() {
                    name = "Tchouchoura",
                    address = new Address() { street = "rue Ampère", zipcode = "38000" },
                    borough = "Grenoble", cuisine = "Balkans",
                    grades = new List<Grade> {
                        new Grade(){date=456, grade="A", score=10},
                        new Grade(){date=789, grade="A", score=10}
                    }
                };

                db.Restaurants.Add(Restau1);
                db.SaveChanges();


                var result = db.Restaurants.Include(r=>r.address).ToList();


                Restau1.name = "toto";
            }
        }

    }
}
