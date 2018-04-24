using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using E_learning_Inheritance_Task2.Classes;
using E_learning_Inheritance_Task2.Enumerations;

namespace E_learning_Inheritance_Task2.Tests
{
    [TestClass()]
    public class TaskTests
    {
        List<Automobile> automobiles = new List<Automobile>
            {
                {new Truck("volvo","fx23",(Colors)2,(FuelTypes)1,800,430,2,(TrailerWeightTypes)2)},
                {new SportCar("nissan","gtr",(Colors)4,(FuelTypes)0,200,480,2,(ExhaustSystemsBrands)2)},
                {new SportCar("bugatti","chiron",(Colors)2,(FuelTypes)1,420,295,8,(ExhaustSystemsBrands)3)},
                {new Car("vaz","2101",(Colors)4,(FuelTypes)0,100,60,1.2,false)},
                {new Truck("mercedes-benz","actros",(Colors)0,(FuelTypes)1,300,490,12,(TrailerWeightTypes)2)},
                {new SportCar("acura","nsx",(Colors)3,(FuelTypes)1,307,570,3.5,(ExhaustSystemsBrands)5)},
                {new Truck("iveko","powerstar",(Colors)1,(FuelTypes)0,220,390,2.2,(TrailerWeightTypes)1)}
            };


        [TestMethod()]
        public void SortByEnginePowerTest()
        {           
            List<Automobile> expected = new List<Automobile>
            {
                {new Car("vaz","2101",(Colors)4,(FuelTypes)0,100,60,1.2,false)},
                {new SportCar("bugatti","chiron",(Colors)2,(FuelTypes)1,420,295,8,(ExhaustSystemsBrands)3)},
                {new Truck("iveko","powerstar",(Colors)1,(FuelTypes)0,220,390,2.2,(TrailerWeightTypes)1)},
                {new Truck("volvo","fx23",(Colors)2,(FuelTypes)1,800,430,2,(TrailerWeightTypes)2)},
                {new SportCar("nissan","gtr",(Colors)4,(FuelTypes)0,200,480,2,(ExhaustSystemsBrands)2)},
                {new Truck("mercedes-benz","actros",(Colors)0,(FuelTypes)1,300,490,12,(TrailerWeightTypes)2)},
                {new SportCar("acura","nsx",(Colors)3,(FuelTypes)1,307,570,3.5,(ExhaustSystemsBrands)5)}

            };

            List<Automobile> actual = Task.SortByEnginePower(automobiles);

            CollectionAssert.AreEqual(expected, actual);         
        }

        [TestMethod()]
        public void FindEconomicalTest()
        {
            double averSpeed = 80;
            Automobile expected = automobiles[3];

            Automobile actual = Task.FindEconomical(automobiles, averSpeed);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void FindTheFastestTest()
        {
            Automobile expected = automobiles[0];

            Automobile actual = Task.FindTheFastest(automobiles);

            Assert.AreEqual(expected, actual);
        }
    }
}