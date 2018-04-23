using System;
using System.Collections.Generic;
using System.Linq;

namespace E_learning_Inheritance_Task2
{
    public class Task
    {
        public static void SortByEnginePower(IList<Automobile> automobiles)
        {
           automobiles =  automobiles.OrderBy( p => p.Horsepowers).ToList();
        }

        public static Automobile FindEconomical(IList<Automobile> automobiles , double avgSpeed)
        {
            return automobiles.OrderBy(p => p.CalculateFuelConsumption(avgSpeed)).FirstOrDefault();
        }

        public static Automobile FindTheFastest(IList<Automobile> automobiles)
        {
            return automobiles.OrderBy(p => p.MaxSpeed).LastOrDefault();
        }

        public static void Print(List<Automobile> automobiles)
        {
            automobiles.ForEach(p => Console.WriteLine(p));
        }
    }
}
