using E_learning_Inheritance_Task2.Enumerations;

namespace E_learning_Inheritance_Task2.Classes
{
    public class Truck : Automobile
    {
        private TrailerWeightTypes trailerWeightType;

        public Truck(
            string _brand,
            string _model,
            Colors _color,
            FuelTypes _fuel,
            uint _maxSpeed,
            double _fuelConsumption,
            double _engineCapacity,
            TrailerWeightTypes _trailerWeightType)
            : base(_brand, _model, _color, _fuel, _maxSpeed, _fuelConsumption, _engineCapacity)
        {
            this.trailerWeightType = _trailerWeightType;
        }

        public override double CalculateFuelConsumption(double averageSpeed)
        {
            return base.CalculateFuelConsumption(averageSpeed) * WeightTypes.GetCoefficient(trailerWeightType);
        }
    }
}
