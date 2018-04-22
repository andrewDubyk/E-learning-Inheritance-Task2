using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_learning_Inheritance_Task2.Enumerations
{
    public enum TrailerWeightTypes
    {
        LightTonnage,
        MiddleTonnage,
        LargeTonnage
    }

    public static class WeightTypes
    {
        public static Dictionary<TrailerWeightTypes, double> fuelConsumptionsCoefficient;

        static WeightTypes()
        {
            fuelConsumptionsCoefficient = new Dictionary<TrailerWeightTypes, double>
            {
                { TrailerWeightTypes.LightTonnage , 1.1},
                { TrailerWeightTypes.MiddleTonnage , 1.2},
                { TrailerWeightTypes.LargeTonnage , 1.3}
            };
        }

        public static double GetCoefficient(TrailerWeightTypes type)
        {
            return fuelConsumptionsCoefficient[type];
        }
    }
}