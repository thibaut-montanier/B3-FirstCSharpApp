using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyFirstAppCSharp.Data.Db;
using System.Linq;

namespace MyFirstAppCSharp.Query.Tests {
    [TestClass]
    public class RestaurautsQueryTest {
        [TestMethod]
        public void FilterTest() {
            using (var db= new RestaurantsContext()) {

                var result = db.Restaurants.FilterByName("Tchouchoura").FilterByZipCode("38000");

                Assert.IsTrue(result.Count() > 0);
            }
        }
    }
}
