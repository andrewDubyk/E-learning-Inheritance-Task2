using E_learning_Inheritance_Task2.Enumerations;
using System;

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

        public override bool Equals(Object obj)
        {
            var item = obj as Car;

            if (item == null)
            {
                return false;
            }

            return base.Equals(item) && this.hasRailsOnRoof == item.hasRailsOnRoof ;
        }

        public override int GetHashCode()
        {
            var hashCode = 1315985931;
            hashCode = hashCode * -1521134295 + base.GetHashCode();
            hashCode = hashCode * -1521134295 + hasRailsOnRoof.GetHashCode();
            return hashCode;
        }
    }
}
