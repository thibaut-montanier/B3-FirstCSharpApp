using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MyFirstAppCSharp.Services.Tests {
    [TestClass]
    public class RestaurantsServiceTests {

        RestaurantsService r = new RestaurantsService();
        [TestMethod]
        public void CreateTest() {

            var listAvant = r.getAll();
            r.Create(new Data.ModelRestau.Restaurant() { name = "toto", cuisine = "Fran�aise et rigolote", borough = "Amp�re" });
            var listApres = r.getAll();

            Assert.IsTrue(listApres.Count == listAvant.Count + 1);

        }
    }
}
