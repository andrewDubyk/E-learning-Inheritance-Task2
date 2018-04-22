using E_learning_Inheritance_Task2.Enumerations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_learning_Inheritance_Task2
{
    public abstract class Automobile : IComparable<Automobile>
    {
        private string brand;
        private string model;
        private Colors color;
        private Guid vin;
        private double fuelConsumption;
        private double engineCapacity;

        public Automobile(
            string _brand,
            string _model,
            Colors _color,
            double _fuelConsumption,
            double _engineCapacity)
        {
            this.brand = _brand;
            this.model = _model;
            this.color = _color;
            this.vin = Guid.NewGuid();
            this.fuelConsumption = _fuelConsumption;
            this.engineCapacity = _engineCapacity;
        }

        public abstract double CalculateFuelConsumption(double averageSpeed);

        public int CompareTo(Automobile other)
        {
            return this.engineCapacity.CompareTo(other.engineCapacity);
        }
    }
}
