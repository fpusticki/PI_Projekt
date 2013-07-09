using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Aplikacija;

namespace JedinicnoTestiranje
{
    [TestClass]
    public class Testiranje
    {
        [TestMethod]
        public void TestMethod1()
        {
            frmPrijava dbClass = new frmPrijava();
            string UserName = "ivo";
            string Password = "ivic";
            string s = dbClass.txtIme;

            Assert.AreEqual(true, s);

            string UserName2 = "skjdsd";
            string Password2 = "123456";
            string p = UserName2;

            Assert.AreEqual(false, p);
        }
    }
}
