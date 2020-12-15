using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyFirstAppCSharp.Data.Db;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyFirstAppCSharp.Tests {
    [TestClass]
    public class ETLTest {
        
        [TestMethod]
        public void LoadAndSelectTest() {
            try {
                var test = MesPremiersRestau();
            }
            catch(Exception e) { 
            }
            
            // do some job here
        }

        public List<RestaurantViewModel> MesPremiersRestau() {
            using (var db = new RestaurantsContext()) {
                throw new Exception("Et oui, je me suis débrouillé pour faire du bug");
                return db.Restaurants.Where(r => r.ID < 10)
                        .Select(r => new RestaurantViewModel {
                            Name = r.name,
                            Cuisine = r.cuisine
                        }).ToList();
            }
        }
    }

    public class RestaurantViewModel {
        public string Name { get; set; }
        public string Cuisine { get; set; }
    }
}
