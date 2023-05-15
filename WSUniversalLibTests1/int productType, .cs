using Microsoft.VisualStudio.TestTools.UnitTesting;
using WSUniversalLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WSUniversalLib.Tests
{
    [TestClass()]
    public class CalculationTests
    {
        [TestMethod()]
        public void GetQuantityForProductTest()
        {
            //подготовка

            Calculation calculation = new Calculation();

            int productType = -8;
            int materialType = 1;
            int count = 15;
            float width = 20f;
            float length = 45f;

            int expected = -1;
            var actual = calculation.GetQuantityForProduct(productType, materialType, count, width, length);

            //проверка

            Assert.AreEqual(expected, actual);
        }
    }

    [TestClass()]
    public class CalculationTests_1
    {
        [TestMethod()]
        public void GetQuantityForProductTest_1()
        {
            //подготовка

            Calculation calculation = new Calculation();

            int productType = 8;
            int materialType = -1;
            int count = 15;
            float width = 20f;
            float length = 45f;

            int expected = -1;
            var actual = calculation.GetQuantityForProduct(productType, materialType, count, width, length);

            //проверка

            Assert.AreEqual(expected, actual);
        }
    }

    [TestClass()]
    public class CalculationTests_2
    {
        [TestMethod()]
        public void GetQuantityForProductTest_2()
        {
            //подготовка

            Calculation calculation = new Calculation();

            int productType = 8;
            int materialType = 1;
            int count = -15;
            float width = 20f;
            float length = 45f;

            int expected = -1;
            var actual = calculation.GetQuantityForProduct(productType, materialType, count, width, length);

            //проверка

            Assert.AreEqual(expected, actual);
        }
    }

    [TestClass()]
    public class CalculationTests_3
    {
        [TestMethod()]
        public void GetQuantityForProductTest_3()
        {
            //подготовка

            Calculation calculation = new Calculation();

            int productType = 8;
            int materialType = 1;
            int count = -15;
            float width = 20f;
            float length = 45f;

            int expected = -1;
            var actual = calculation.GetQuantityForProduct(productType, materialType, count, width, length);

            //проверка

            Assert.AreEqual(expected, actual);
        }
    }

    [TestClass()]
    public class CalculationTests_4
    {
        [TestMethod()]
        public void GetQuantityForProductTest_4()
        {
            //подготовка

            Calculation calculation = new Calculation();

            int productType = 8;
            int materialType = 1;
            int count = 15;
            float width = -20f;
            float length = 45f;

            int expected = -1;
            var actual = calculation.GetQuantityForProduct(productType, materialType, count, width, length);

            //проверка

            Assert.AreEqual(expected, actual);
        }
    }

    [TestClass()]
    public class CalculationTests_5
    {
        [TestMethod()]
        public void GetQuantityForProductTest_5()
        {
            //подготовка

            Calculation calculation = new Calculation();

            int productType = 8;
            int materialType = 1;
            int count = 15;
            float width = 20f;
            float length = -45f;

            int expected = -1;
            var actual = calculation.GetQuantityForProduct(productType, materialType, count, width, length);

            //проверка

            Assert.AreEqual(expected, actual);
        }
    }


}