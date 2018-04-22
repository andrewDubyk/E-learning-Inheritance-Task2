using E_learning_Inheritance_Task2.Classes;
using E_learning_Inheritance_Task2.Enumerations;
using System;

namespace E_learning_Inheritance_Task2
{
    public abstract class Automobile : IComparable<Automobile>
    {
        private string brand;
        private string model;
        private Colors color;
        private Guid vin;
        private FuelTypes fuel;
        private uint maxSpeed;
        private double horsepowers;
        private double engineCapacity;

        public Automobile(
            string _brand,
            string _model,
            Colors _color,
            FuelTypes _fuel,
            uint _maxSpeed,
            double _horsepowers,
            double _engineCapacity)
        {
            this.brand = _brand;
            this.model = _model;
            this.color = _color;
            this.vin = Guid.NewGuid();
            this.fuel = _fuel;
            this.maxSpeed = _maxSpeed;
            this.horsepowers = _horsepowers;
            this.engineCapacity = _engineCapacity;
        }

        public virtual double CalculateFuelConsumption(double averageSpeed)
        {
            var watts = Utils.HpsToWatt(this.horsepowers);
            var distance = Utils.KilometersToMeters(1);
            var speed = Utils.KilometersPerHourToMetersPerSecond(averageSpeed);
            var ece = Utils.EnrgyConversionEfficiency(this.horsepowers, this.engineCapacity);

            var result = watts * distance / (speed * ece * Utils.benzinHeatOfCombustion);
            return result;
        }

        public int CompareTo(Automobile other)
        {
            return this.engineCapacity.CompareTo(other.engineCapacity);
        }
    }
}
