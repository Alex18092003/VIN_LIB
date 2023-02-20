using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using VIN_LIB;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        //проверка на то, что метод возвращает тип string
        [TestMethod]
        public void GetVINCountry_ReturnCorrectlyType()
        {
            string vin = "1265515565";
            string actual = Class1.GetVINCountry(vin);

            Assert.IsInstanceOfType(actual, typeof(string));
        }

        //проверка на то, что метод не возвращает тип bool
        [TestMethod]
        public void GetVINCountry_NoReturnNoCorrectlyType()
        {
            string vin = "1265515565";
            string actual = Class1.GetVINCountry(vin);

            Assert.IsNotInstanceOfType(actual, typeof(bool));
        }

        // проверка на корректную работу метода, при верных данных
        [TestMethod]
        public void GetVINCountry_ReturnCorrectlyResultWithCorrectData()
        {
            string vin = "1235D59684A896523";
            string except = "Северная Америка";
            string actual = Class1.GetVINCountry(vin);
            Assert.AreEqual(except, actual);
        }

        //проверка на корректунюу работу метода, при неверных ьданных
        [TestMethod]
        public void GetVINCountry_ReturnNoCorrectlyResultWithCorrectData()
        {
            string vin = "121555244854841";
            string except = "Европа";
            string actual = Class1.GetVINCountry(vin);
            Assert.AreNotEqual(except, actual);
        }

        // проверка на корректную работу метода, при верных данных
        [TestMethod]
        public void CheckVIN_ReturnCorrectlyResultWithCorrectData()
        {
            string vin = "1235625365962535A";
            bool except = true;
            bool actual = Class1.CheckVIN(vin);
            Assert.AreEqual(except, actual);
        }

        // проверка на корректуную работу метода, при неверных данных
        [TestMethod]
        public void CheckVIN_ReturnCorrectlyResultWithNoCorrectData()
        {
            string vin = "12356253659";
            bool except = false;
            bool actual = Class1.CheckVIN(vin);
            Assert.AreEqual(except, actual);
        }

        // проверка на то, что метод не выводит true при не верных данных
        [TestMethod]
        public void CheckVIN_ReturnNoCorrectlyResultWithNoCorrectData()
        {
            string vin = "12356253659";
            bool except = true;
            bool actual = Class1.CheckVIN(vin);
            Assert.AreNotEqual(except, actual);
        }

        // проверка на то, что метод не выводит false при верных данных
        [TestMethod]
        public void CheckVIN_ReturnNoCorrectlyResultWithCorrectData()
        {
            string vin = "1235625365962535A";
            bool except = false;
            bool actual = Class1.CheckVIN(vin);
            Assert.AreNotEqual(except, actual);
        }

        //проверка на то, что метод возвращает тип bool
        [TestMethod]
        public void CheckVIN_ReturnCorrectlyType()
        {
            string vin = "1265515565";
            bool actual = Class1.CheckVIN(vin);

            Assert.IsInstanceOfType(actual, typeof(bool));
        }


        //проверка на то, что метод не возвращает тип string
        [TestMethod]
        public void CheckVIN_ReturnNoCorrectlyType()
        {
            string vin = "1265515565";
            bool actual = Class1.CheckVIN(vin);

            Assert.IsNotInstanceOfType(actual, typeof(string));
        }
        //проверка на то, что метод возвращает верно 
        [TestMethod]
        public void CheckVIN_ReturnCorrectlyResult()
        {
            string vin = "10202032659566325";
            bool actual = Class1.CheckVIN(vin);

            Assert.IsTrue(actual);
        }

        //проверка на то, что метод возвращает верно 
        [TestMethod]
        public void GetVINCountr_ReturnCorrectlyResult()
        {
            string vin = "10202032659566325";
            string actual = Class1.GetVINCountry(vin);

            Assert.IsTrue(actual == "Северная Америка");
        }
        //проверка на то, что метод возвращает верно 
        [TestMethod]
        public void GetVINCountr_ReturnNoCorrectlyResult()
        {
            string vin = "10202032659566325";
            string actual = Class1.GetVINCountry(vin);

            Assert.IsFalse(actual == "Европа");
        }

        //проверка на то, что метод возвращает верно 
        [TestMethod]
        public void CheckVIN_CorrectlyTrue()
        {
            string vin = "10202032659566325";
            bool actual = Class1.CheckVIN(vin);

            Assert.IsTrue(actual);
        }

        //проверка на то, что метод возвращает не ноль при верных данных
        [TestMethod]
        public void CheckVIN_ReturnNotNullWithCorrectData()
        {
            string vin = "10202032659566325";
            bool actual = Class1.CheckVIN(vin);

            Assert.IsNotNull(actual);
        }


        //проверка на то, что метод возвращает не ноль при не верных данных
        [TestMethod]
        public void CheckVIN_ReturnNotNullWithNoCorrectDat()
        {
            string vin = "мыымвывуау";
            bool actual = Class1.CheckVIN(vin);

            Assert.IsNotNull(actual);
        }


        //проверка на то, что метод возвращает не ноль при верных данных
        [TestMethod]
        public void GetVINCountry_ReturnNotNullWithCorrectData()
        {
            string vin = "10202032659566325";
            string actual = Class1.GetVINCountry(vin);

            Assert.IsNotNull(actual);
        }

        //проверка на то, что метод возвращает не ноль при не верных данных
        [TestMethod]
        public void GetVINCountryN_ReturnNotNullWithNoCorrectData()
        {
            string vin = "мыымвывуау";
            string actual = Class1.GetVINCountry(vin);

            Assert.IsNotNull(actual);
        }
    }
}
