using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_learning_Inheritance_Task2.Enumerations
{
    public enum RoofTypes
    {
        RoofWithoutRails,
        RoofWithRails
    }

    public static class Roofs
    {
        public static Dictionary<RoofTypes, double> resistanceСoefficient;

        static Roofs()
        {
            resistanceСoefficient = new Dictionary<RoofTypes, double>
            {
                { RoofTypes.RoofWithoutRails , 1.0},
                { RoofTypes.RoofWithRails , 1.1}
            };
        }

        public static double GetCoefficient(RoofTypes type)
        {
            return resistanceСoefficient[type];
        }
    }

}
