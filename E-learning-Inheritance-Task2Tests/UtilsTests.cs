using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using E_learning_Inheritance_Task2.Enumerations;

namespace E_learning_Inheritance_Task2.Classes.Tests
{
    [TestClass()]
    public class UtilsTests
    {
        private TestContext testContext;

        public TestContext TestContext { get => testContext; set => testContext = value; }

        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV",
                   "|DataDirectory|\\EceTests.csv", "EceTests#csv", DataAccessMethod.Sequential),
           DeploymentItem("UtilsTestData\\EceTests.csv"), TestMethod]
        public void GetEceByFuelTypeTest()
        {
            int fuelType = Int32.Parse(TestContext.DataRow["fuelType"].ToString());
            double result = double.Parse(TestContext.DataRow["result"].ToString().Replace('.',','));

            double actual = Utils.GetEceByFuelType((FuelTypes)fuelType);

            Assert.AreEqual(result, actual);
        }

        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV",
                          "|DataDirectory|\\KilometersPerHourToMetersPerSecondTests.csv", "KilometersPerHourToMetersPerSecondTests#csv", DataAccessMethod.Sequential),
                  DeploymentItem("UtilsTestData\\KilometersPerHourToMetersPerSecondTests.csv"), TestMethod]
        public void KilometersPerHourToMetersPerSecondTest()
        {
            int kmPerHour = Int32.Parse(TestContext.DataRow["kmPerHour"].ToString());
            double result = double.Parse(TestContext.DataRow["result"].ToString().Replace('.', ','));

            double actual = Utils.KilometersPerHourToMetersPerSecond(kmPerHour);

            Assert.AreEqual(result, actual);
        }

        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV",
                  "|DataDirectory|\\KilometersToMetersTests.csv", "KilometersToMetersTests#csv", DataAccessMethod.Sequential),
          DeploymentItem("UtilsTestData\\KilometersToMetersTests.csv"), TestMethod]
        public void KilometersToMetersTest()
        {
            int kms = Int32.Parse(TestContext.DataRow["kms"].ToString());
            double result = double.Parse(TestContext.DataRow["result"].ToString().Replace('.', ','));

            double actual = Utils.KilometersToMeters(kms);

            Assert.AreEqual(result, actual);
        }

        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV",
                  "|DataDirectory|\\HpsToWattTests.csv", "HpsToWattTests#csv", DataAccessMethod.Sequential),
          DeploymentItem("UtilsTestData\\HpsToWattTests.csv"), TestMethod]
        public void HpsToWattTest()
        {
            int hps = Int32.Parse(TestContext.DataRow["hps"].ToString());
            double result = double.Parse(TestContext.DataRow["result"].ToString().Replace('.', ','));

            double actual = Utils.HpsToWatt(hps);

            Assert.AreEqual(result, actual, 10e-3);
        }
    }
}