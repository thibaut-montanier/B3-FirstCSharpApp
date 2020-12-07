using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyFirstAppCSharp.Data.ModelRestau;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace MyFirstAppCSharp.Tests {

    [TestClass]
    public class JsonRestaurantTest {
        

        [TestMethod]
        public void LoadJsonFile() {
            string fileName = @".\Ressources\restaurants.net.json";
            RestauJsonService srv = new RestauJsonService();
            var result = srv.loadFromFile(fileName);

            Assert.IsTrue(result.Count > 0);
        }
    }
}
