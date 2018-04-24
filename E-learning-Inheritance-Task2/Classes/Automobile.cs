using E_learning_Inheritance_Task2.Classes;
using E_learning_Inheritance_Task2.Enumerations;
using System;
using System.Collections.Generic;

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
            var ece = Utils.GetEceByFuelType(this.Fuel);
            var result = watts * distance / (speed * ece * Utils.benzinHeatOfCombustion);
            return result;
        }

        public override string ToString()
        {
            return string.Format(
                $"brand : {this.Brand}\n" +
                $"model : {this.Model}\n" +
                $"color : {Enum.GetName(typeof(Colors), this.Color)}\n" +
                $"fule : {Enum.GetName(typeof(FuelTypes), this.Fuel)}\n" +
                $"max speed : {this.MaxSpeed}\n" +
                $"horse powers : {this.Horsepowers}\n" +
                $"engine capactiy : {this.EngineCapacity}\n");
        }

        public override bool Equals(Object obj)
        {
            var item = obj as Automobile;

            if (item == null)
            {
                return false;
            }

            return this.Brand == item.Brand && this.Model == item.Model && this.Color == item.Color
                    && this.Fuel == item.Fuel && this.MaxSpeed == item.MaxSpeed
                    && this.Horsepowers == item.Horsepowers && this.EngineCapacity == item.EngineCapacity;
        }

        public override int GetHashCode()
        {
            var hashCode = 793576678;
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Brand);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Model);
            hashCode = hashCode * -1521134295 + Color.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<Guid>.Default.GetHashCode(Vin);
            hashCode = hashCode * -1521134295 + Fuel.GetHashCode();
            hashCode = hashCode * -1521134295 + MaxSpeed.GetHashCode();
            hashCode = hashCode * -1521134295 + Horsepowers.GetHashCode();
            hashCode = hashCode * -1521134295 + EngineCapacity.GetHashCode();
            return hashCode;
        }
    }
}
