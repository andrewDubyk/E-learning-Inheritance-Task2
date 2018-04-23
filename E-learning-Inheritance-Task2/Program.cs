using E_learning_Inheritance_Task2.Classes;
using E_learning_Inheritance_Task2.Enumerations;
using System;
using System.Collections.Generic;

namespace E_learning_Inheritance_Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Automobile> automobiles = new List<Automobile>
            {
                {new Truck("volvo","fx23",(Colors)2,(FuelTypes)1,800,430,2,(TrailerWeightTypes)2)},
                {new SportCar("nissan","gtr",(Colors)4,(FuelTypes)0,200,480,2,(ExhaustSystemsBrands)2)},
                {new SportCar("ford","mustang",(Colors)3,(FuelTypes)1,230,380,2.4,(ExhaustSystemsBrands)5)}
            };



            Console.WriteLine("\t\t\t The most economical \n");
            Console.WriteLine(Task.FindEconomical(automobiles, 80));

            Console.WriteLine("\t\t\t The fastest \n");
            Console.WriteLine(Task.FindTheFastest(automobiles));

            List<Automobile> sorted = Task.SortByEnginePower(automobiles);
            Console.WriteLine("\t\t\t Automobiles sorted by hourspowers \n");
            Task.Print(automobiles);


            foreach(var a in automobiles)
            {
                Console.WriteLine(a.CalculateFuelConsumption(80));
            }


            Console.ReadKey();
        }
    }
}
