using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Brito;


namespace Pruebas_Unitarias
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void PruebaSave()
        {
            //Organizar
            Company comp = new Company("Alfa", 2000);
            double valoresperado = 2500;
            //Actuar
            comp.Save(500);
            double valorobtenido = comp.SaveProject;
            //Afirmar
            Assert.AreEqual(valoresperado, valorobtenido);
        }

        [TestMethod]
        public void PruebaSpend()
        {
            //Organizar
            Company comp = new Company("Alfa", 2000);
            double valoresperado = 1500;
            //Actuar
            comp.Spend(500);
            double valorobtenido = comp.SaveProject;
            //Afirmar
            Assert.AreEqual(valoresperado, valorobtenido);
        }

        [TestMethod]
        public void PruebaChangeName()
        {
            //Organizar
            Company comp = new Company("Alfa", 2000);
            double valoresperado = 2500;
            //Actuar
            comp.ChangeName("Beta");
            double valorobtenido = comp.SaveProject;
            //Afirmar
            Assert.AreEqual(valoresperado, valorobtenido);
        }



    }
}
