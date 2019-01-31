using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using EquazioniLibrary;

namespace EquazioniLibrary.Tests
{
    [TestClass]
    public class Equazioni_Tests
    {
        [TestMethod]
        public void TestIsDetermined()
        {
            double a = 3;
            bool risp_attesa = true;
            bool risp = Equazioni.IsDetermined(a);
            Assert.AreEqual(risp_attesa, risp);
        }

        [TestMethod]
        public void TestIsDetermined1()
        {
            double a = -3;
            bool risp_attesa = true;
            bool risp = Equazioni.IsDetermined(a);
            Assert.AreEqual(risp_attesa, risp);
        }

        [TestMethod]
        public void TestIsDetermined2()
        {
            double a = 0;
            bool risp_attesa = false;
            bool risp = Equazioni.IsDetermined(a);
            Assert.AreEqual(risp_attesa, risp);
        }
    }
}
