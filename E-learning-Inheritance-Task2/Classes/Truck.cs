using E_learning_Inheritance_Task2.Enumerations;

namespace E_learning_Inheritance_Task2.Classes
{
    public class Truck : Automobile
    {
        private double maximumTrailerWeight;

        public Truck(
            string _brand,
            string _model,
            Colors _color,
            double _horsepowers,
            double _engineCapacity,
            double _maximumTrailerWeight)
            : base(_brand, _model, _color, _horsepowers, _engineCapacity)
        {
            this.maximumTrailerWeight = _maximumTrailerWeight;
        }

        public override double CalculateFuelConsumption(double averageSpeed)
        {
            return base.CalculateFuelConsumption(averageSpeed);
        }
    }
}
