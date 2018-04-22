using E_learning_Inheritance_Task2.Enumerations;

namespace E_learning_Inheritance_Task2.Classes
{
    public class Car : Automobile
    {
        private bool hasRailsOnRoof;

        public Car(
            string _brand,
            string _model,
            Colors _color,
            FuelTypes _fuel,
            uint _maxSpeed,
            double _horsepowers,
            double _engineCapacity,
            bool _hasRailsOnRoof)
            : base(_brand, _model, _color, _fuel, _maxSpeed, _horsepowers, _engineCapacity)
        {
            this.hasRailsOnRoof = _hasRailsOnRoof;
        }

        public override double CalculateFuelConsumption(double averageSpeed)
        {
            double resistanceСoefficient = hasRailsOnRoof ? 1.11 : 1; 
            return base.CalculateFuelConsumption(averageSpeed) * resistanceСoefficient;
        }
    }
}
