using E_learning_Inheritance_Task2;
using System.Collections.Generic;
using E_learning_Inheritance_Task2.Classes;
using E_learning_Inheritance_Task2.Enumerations;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace E_learning_Inheritance_Task2Tests.ClassesTests
{
    [TestClass]
    public class SportCatTests
    {
        [TestMethod]
        public void CalculateFuelConsumptionTest()
        {
            List<Automobile> automobiles = new List<Automobile>
            {
                 {new SportCar("bugatti","chiron",(Colors)2,(FuelTypes)1,420,295,8,(ExhaustSystemsBrands)3)},
                 {new SportCar("nissan","gtr",(Colors)4,(FuelTypes)0,200,480,2,(ExhaustSystemsBrands)2)},
                 {new SportCar("acura","nsx",(Colors)3,(FuelTypes)1,307,570,3.5,(ExhaustSystemsBrands)5)}
            };
            double averSpeed = 100;
            List<double> expected = new List<double>()
            {
                { 0.57635 },
                { 1.15494 },
                { 0.93604 }
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
            Automobile automobile1 = new SportCar("acura", "nsx", (Colors)3, (FuelTypes)1, 307, 570, 3.5, (ExhaustSystemsBrands)5);
            Automobile automobile2 = new SportCar("acura", "nsx", (Colors)3, (FuelTypes)1, 307, 570, 3.5, (ExhaustSystemsBrands)5);
            bool expected = true;

            bool actual = automobile1.Equals(automobile2);

            Assert.AreEqual(expected, actual);
        }
    }
}
