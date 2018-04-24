using E_learning_Inheritance_Task2;
using System.Collections.Generic;
using E_learning_Inheritance_Task2.Classes;
using E_learning_Inheritance_Task2.Enumerations;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace E_learning_Inheritance_Task2Tests
{
    [TestClass]
    public class TruckTests
    {
        [TestMethod]
        public void CalculateFuelConsumptionTest()
        {
            List<Automobile> automobiles = new List<Automobile>
            {
                 {new Truck("volvo","fx23",(Colors)2,(FuelTypes)1,800,430,2,(TrailerWeightTypes)2)},
                 {new Truck("iveko","powerstar",(Colors)1,(FuelTypes)0,220,390,2.2,(TrailerWeightTypes)1)},
                 {new Truck("mercedes-benz","actros",(Colors)0,(FuelTypes)1,300,490,12,(TrailerWeightTypes)2) }
            };
            double averSpeed = 100;
            List<double> expected = new List<double>()
            {
                { 0.83369 },
                { 0.93063 },
                { 0.95002 }
            };

            List<double> actual = new List<double>();
            foreach (var automobile in automobiles)
            {
                actual.Add(System.Math.Round(automobile.CalculateFuelConsumption(averSpeed), 5));
            }

            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void EqualsTest()
        {
            Automobile automobile1 = new Truck("iveko", "345", (Colors)2, (FuelTypes)0, 220, 400, 2.2, (TrailerWeightTypes)1);
            Automobile automobile2 = new Truck("iveko", "345", (Colors)2, (FuelTypes)0, 220, 400, 2.2, (TrailerWeightTypes)1);
            bool expected = true;

            bool actual = automobile1.Equals(automobile2);

            Assert.AreEqual(expected, actual);
        }
    }
}
