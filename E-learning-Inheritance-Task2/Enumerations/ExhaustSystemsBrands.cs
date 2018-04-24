using System.Collections.Generic;

namespace E_learning_Inheritance_Task2.Enumerations
{
    public enum ExhaustSystemsBrands
    {
        Rogue,
        Magnaflow,
        Mufflers,
        Dynomax,
        APEXi,
        Akrapovic,
        Megan
    }

    public static class ExhaustSystems
    {
        public static Dictionary<ExhaustSystemsBrands, double> fuelConsumptionsCoefficient;

        static ExhaustSystems()
        {
            fuelConsumptionsCoefficient = new Dictionary<ExhaustSystemsBrands, double>
            {
                { ExhaustSystemsBrands.Rogue , 1.1},
                { ExhaustSystemsBrands.Magnaflow , 1.12},
                { ExhaustSystemsBrands.Mufflers , 1.21},
                { ExhaustSystemsBrands.Dynomax , 1.31},
                { ExhaustSystemsBrands.APEXi , 1.122},
                { ExhaustSystemsBrands.Akrapovic , 1.1011},
                { ExhaustSystemsBrands.Megan , 1.177}
            };
        }

        public static double GetCoefficient(ExhaustSystemsBrands brand)
        {
            return fuelConsumptionsCoefficient[brand];
        }
    }
}
