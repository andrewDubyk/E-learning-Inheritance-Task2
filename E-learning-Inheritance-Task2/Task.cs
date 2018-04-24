using System;
using System.Collections.Generic;
using System.Linq;

namespace E_learning_Inheritance_Task2
{
    public class Task
    {
        public static List<Automobile> SortByEnginePower(List<Automobile> automobiles)
        {
            return automobiles.OrderBy(p => p.Horsepowers).ToList();
        }

        public static Automobile FindEconomical(List<Automobile> automobiles , double avgSpeed)
        {
            return automobiles.OrderBy(p => p.CalculateFuelConsumption(avgSpeed)).FirstOrDefault();
        }

        public static Automobile FindTheFastest(List<Automobile> automobiles)
        {
            return automobiles.OrderBy(p => p.MaxSpeed).LastOrDefault();
        }

        public static void Print(List<Automobile> automobiles)
        {
            automobiles.ForEach(p => Console.WriteLine(p));
        }
    }
}
