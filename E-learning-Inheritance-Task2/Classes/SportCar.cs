using E_learning_Inheritance_Task2.Enumerations;

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
    }
}
