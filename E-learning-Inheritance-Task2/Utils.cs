using E_learning_Inheritance_Task2.Enumerations;

namespace E_learning_Inheritance_Task2.Classes
{

    public static class Utils
    {
        public static double wattToHp = 735.49875;
        public static double benzinHeatOfCombustion = 45000000;
        public static double eceForPetrol = 0.3;
        public static double eceForDiesel = 0.4;


        public static double GetEceByFuelType(FuelTypes fuelType)
        {
            if (fuelType is (FuelTypes)1)
            {
                return eceForPetrol;
            }
            else return eceForDiesel;
        }

        public static double KilometersPerHourToMetersPerSecond(double kilometersPerHour)
        {
            return (kilometersPerHour * 10) / 36;
        }

        public static double KilometersToMeters(double kilometers)
        {
            return kilometers * 1000;
        }

        public static double HpsToWatt(double hps)
        {
            return hps * wattToHp;
        }
        
    }

}
