using E_learning_Inheritance_Task2.Enumerations;
using System;

namespace E_learning_Inheritance_Task2.Classes
{
    public class Car : Automobile
    {
        private RoofTypes roofType;

        public Car(
            string _brand,
            string _model,
            Colors _color,
            FuelTypes _fuel,
            uint _maxSpeed,
            double _horsepowers,
            double _engineCapacity,
            RoofTypes _roofType)
            : base(_brand, _model, _color, _fuel, _maxSpeed, _horsepowers, _engineCapacity)
        {
            this.roofType = _roofType;
        }

        public override double CalculateFuelConsumption(double averageSpeed)
        {
            return base.CalculateFuelConsumption(averageSpeed) * Roofs.GetCoefficient(roofType);          
        }

        public override bool Equals(Object obj)
        {
            var item = obj as Car;

            if (item == null)
            {
                return false;
            }

            return base.Equals(item) && this.roofType == item.roofType;
        }

        public override int GetHashCode()
        {
            var hashCode = 1315985931;
            hashCode = hashCode * -1521134295 + base.GetHashCode();
            hashCode = hashCode * -1521134295 + roofType.GetHashCode();
            return hashCode;
        }
    }
}
