using E_learning_Inheritance_Task2.Enumerations;
using System;

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

        public override string ToString()
        {
            return base.ToString() + string.Format($"Trailer weight type : {Enum.GetName(typeof(TrailerWeightTypes), this.trailerWeightType)}\n");
        }

        public override bool Equals(Object obj)
        {
            var item = obj as Truck;

            if (item == null)
            {
                return false;
            }

            return base.Equals(item) && this.trailerWeightType == item.trailerWeightType ;
        }

        public override int GetHashCode()
        {
            var hashCode = -1619085688;
            hashCode = hashCode * -1521134295 + base.GetHashCode();
            hashCode = hashCode * -1521134295 + trailerWeightType.GetHashCode();
            return hashCode;
        }
    }
}
