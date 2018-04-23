using E_learning_Inheritance_Task2.Enumerations;
using System;

namespace E_learning_Inheritance_Task2.Classes
{
    public class SportCar : Automobile
    {
        private ExhaustSystemsBrands exhaustSystemBrand;

        public SportCar(
            string _brand,
            string _model,
            Colors _color,
            FuelTypes _fuel,
            uint _maxSpeed,
            double _horsepowers,
            double _engineCapacity,
            ExhaustSystemsBrands _exhaustSystemBrand)
            : base(_brand, _model, _color, _fuel, _maxSpeed, _horsepowers, _engineCapacity)
        {
            this.exhaustSystemBrand = _exhaustSystemBrand;
        }

        public override double CalculateFuelConsumption(double averageSpeed)
        {
            return base.CalculateFuelConsumption(averageSpeed) * ExhaustSystems.GetCoefficient(exhaustSystemBrand);
        }

        public override string ToString()
        {
            return base.ToString() + string.Format($"exhaustSystemBrand : {Enum.GetName(typeof(ExhaustSystemsBrands), this.exhaustSystemBrand)}\n");
        }

        public override bool Equals(Object obj)
        {
            var item = obj as SportCar;

            if (item == null)
            {
                return false;
            }

            return base.Equals(item) && this.exhaustSystemBrand == item.exhaustSystemBrand; ;
        }

        public override int GetHashCode()
        {
            var hashCode = 177775825;
            hashCode = hashCode * -1521134295 + base.GetHashCode();
            hashCode = hashCode * -1521134295 + exhaustSystemBrand.GetHashCode();
            return hashCode;
        }
    }
}
