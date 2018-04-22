using E_learning_Inheritance_Task2.Classes;
using E_learning_Inheritance_Task2.Enumerations;
using System;

namespace E_learning_Inheritance_Task2
{
    public abstract class Automobile
    {
        public string Brand { get; private set; }
        public string Model { get; private set; }
        public Colors Color { get; private set; }
        public Guid Vin { get; private set; }
        public FuelTypes Fuel { get; private set; }
        public uint MaxSpeed { get; private set; }
        public double Horsepowers { get; private set; }
        public double EngineCapacity { get; private set; }

        public Automobile(
            string _brand,
            string _model,
            Colors _color,
            FuelTypes _fuel,
            uint _maxSpeed,
            double _horsepowers,
            double _engineCapacity)
        {
            this.Brand = _brand;
            this.Model = _model;
            this.Color = _color;
            this.Vin = Guid.NewGuid();
            this.Fuel = _fuel;
            this.MaxSpeed = _maxSpeed;
            this.Horsepowers = _horsepowers;
            this.EngineCapacity = _engineCapacity;
        }

        public virtual double CalculateFuelConsumption(double averageSpeed)
        {
            var watts = Utils.HpsToWatt(this.Horsepowers);
            var distance = Utils.KilometersToMeters(1);
            var speed = Utils.KilometersPerHourToMetersPerSecond(averageSpeed);
            var ece = Utils.EnrgyConversionEfficiency(this.Horsepowers, this.EngineCapacity);

            var result = watts * distance / (speed * ece * Utils.benzinHeatOfCombustion);
            return result;
        }

        public override string ToString()
        {
            return string.Format(
                $"brand : {this.Brand}\n" +
                $"model : {this.Model}\n" +
                $"color : {Enum.GetName(typeof(Colors),this.Color)}\n" +
                $"fule : {Enum.GetName(typeof(FuelTypes),this.Fuel)}\n" +
                $"max speed : {this.MaxSpeed}\n" +
                $"horse powers : {this.Horsepowers}\n" +
                $"engine capactiy : {this.EngineCapacity}\n");
        }
    }
}
