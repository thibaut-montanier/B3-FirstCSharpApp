using MyFirstAppCSharp.Data.Db;
using MyFirstAppCSharp.Data.ModelRestau;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MyFirstAppCSharp.Services {
    public class RestaurantsService {

        public List<Restaurant> getAll() {
            using (var db = new RestaurantsContext()) {
                return db.Restaurants.ToList();
            }
        }

        public void Create(Restaurant r) {
            using( var db = new RestaurantsContext()) {
                db.Restaurants.Add(r);
                db.SaveChanges();
            }
        }


        public void Update(Restaurant r) {
            using (var db = new RestaurantsContext()) {
                db.Restaurants.Attach(r);
                db.SaveChanges();
            }
        }
    }
}
