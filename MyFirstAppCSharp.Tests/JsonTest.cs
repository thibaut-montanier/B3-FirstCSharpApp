using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyFirstAppCSharp.Tests {

    [TestClass]
    public class JsonTest {

        [TestMethod]
        public void TestSerializeDeserialize() {

            Person p1 = new Person() { Nom = "Pierre", Age = 16 };
            Person p2 = new Person() { Nom = "Jean", Age = 16 };
            List<Person> mesPers = new List<Person> {
                p1,
                p2,
                new Person() { Nom = "Sohpie", Age = 20},
                new Person() { Nom = "ANais", Age = 30},
                new Person() { Nom = "Paul", Age = 5},
                new Person() { Nom = "Fabrice", Age = 45},
                new Person() { Nom = "Julie", Age = 17 }
            };

            Car c1 = new Car() { Annee = 1999, Model = "Clio" };
            Car c2 = new Car() { Annee = 1999, Model = "206" };
            Car c3 = new Car() { Annee = 1985, Model = "R5" };


            p1.Cars.Add(c1);
            p1.Cars.Add(c2);
            p2.Cars.Add(c1);

            c1.Annee = 2005;
            // conversion Json
            string result = JsonConvert.SerializeObject(mesPers);

            // récupération du résultat

            var resultObj = JsonConvert.DeserializeObject<List<Person>>(result);

            var rp1 = resultObj[0];
            var rp2 = resultObj[1];

            rp1.Cars[0].Model = "Toto";
            rp2.Cars[0] = rp1.Cars[0];

            Assert.AreEqual(rp1.Cars[0].Model, rp2.Cars[1].Model);

        }
    }

    public class PersonSerializerModel {
        public List<Person> lesPersonnes { get; set; }

        public List<Car> lesVoitures { get; set; }
    }
}
