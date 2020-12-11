using MyFirstAppCSharp.Data.ModelRestau;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyFirstAppCSharp.Query {
    public static class RestaurantExtensions {

        public static IQueryable<Restaurant> FilterByName(this IQueryable<Restaurant> values, string Name) {
            return values.Where(r => r.name == Name);
        }
        public static IQueryable<Restaurant> FilterByZipCode(this IQueryable<Restaurant> values, string zipcode) {
            return values.Where(r => r.address.zipcode== zipcode);
        }
    }
}
