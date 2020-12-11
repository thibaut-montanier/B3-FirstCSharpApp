using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstAppCSharp.Tests {
    [TestClass]
    public class EntiersServiceTest {



        [TestMethod]
        public void AddTest() {
            var entSrv = new EntiersService();


            Assert.AreEqual(4, entSrv.Add(1, 3));

            // 
            var result = 3 + 1;

            Assert.AreEqual(result, entSrv.Add(1, 3));

        }

        [TestMethod]
        public void isEvenTest() {
            var entSrv = new EntiersService();
            Assert.IsFalse(entSrv.isEven(3));
            Assert.IsTrue(entSrv.isEven(2));
        }


        [TestMethod]
        [DataRow(1, false)]
        public void isEvenTest(int value, bool result) {
            var entSrv = new EntiersService();
            var l = new List<int>();
            var l2 = new List<int>();

            Assert.AreEqual(value, result);


            
        }


    }
}
