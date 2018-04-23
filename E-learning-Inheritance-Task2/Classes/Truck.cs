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
            double _horsepowers,
            double _engineCapacity,
            TrailerWeightTypes _trailerWeightType)
            : base(_brand, _model, _color, _fuel, _maxSpeed, _horsepowers, _engineCapacity)
        {
            this.trailerWeightType = _trailerWeightType;
        }

        public override double CalculateFuelConsumption(double averageSpeed)
        {
            return base.CalculateFuelConsumption(averageSpeed) * WeightTypes.GetCoefficient(trailerWeightType);
        }

        //public override bool Equals(Object obj)
        //{
        //    if (obj is Truck)
        //    {
        //        var that = obj as Truck;
        //        return this.Equals(that) && this.trailerWeightType == that.trailerWeightType;
        //    }

        //    return false;
        //}
    }
}
