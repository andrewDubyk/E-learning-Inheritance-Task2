using E_learning_Inheritance_Task2;
using System.Collections.Generic;
using E_learning_Inheritance_Task2.Classes;
using E_learning_Inheritance_Task2.Enumerations;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace E_learning_Inheritance_Task2Tests.ClassesTests
{
    [TestClass]
    public class CarTests
    {
        [TestMethod]
        public void CalculateFuelConsumptionTest()
        {
            List<Automobile> automobiles = new List<Automobile>
            {
                 {new Car("vaz","2101",(Colors)4,(FuelTypes)0,100,60,1.2,(RoofTypes)0)},
                 {new Car("mercedes-benz","actros",(Colors)0,(FuelTypes)1,300,480,2, (RoofTypes)1)}
            };
            double averSpeed = 80;
            List<double> expected = new List<double>()
            {
                { 0.14914 },
                { 0.98432 }
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
            Automobile automobile1 = new Car("vaz", "2101", (Colors)4, (FuelTypes)0, 100, 60, 1.2, (RoofTypes)0);
            Automobile automobile2 = new Car("vaz", "2101", (Colors)4, (FuelTypes)0, 100, 60, 1.2, (RoofTypes)0);
            bool expected = true;

            bool actual = automobile1.Equals(automobile2);

            Assert.AreEqual(expected, actual);
        }
    }
}