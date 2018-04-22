namespace E_learning_Inheritance_Task2.Classes
{

    public static class Utils
    {
        public static double wattToHp = 745.699872;
        public static int fourCycleEngineCoefficient = 2;
        public static double cubicMeters = 1 * 10e-3;
        public static int revolutionsPerMinute = 3000;
        public static double averageIndicatorGasPressure = 9.81 * 10e+4;

        public static double benzinHeatOfCombustion = 45000000;

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

        public static double LitersToCubicMeters(double liters)
        {
            return liters * cubicMeters;
        }

        public static double PowerIn(double engineCapacity)
        {
            return averageIndicatorGasPressure * LitersToCubicMeters(engineCapacity) * revolutionsPerMinute / (fourCycleEngineCoefficient * 60 * 75);
        }

        public static double EnrgyConversionEfficiency(double horsepowers, double engineCapacity)
        {
            double powerOut = HpsToWatt(horsepowers);
            double powerIn = PowerIn(engineCapacity);

            return powerIn / powerOut;
        }
    }

}
