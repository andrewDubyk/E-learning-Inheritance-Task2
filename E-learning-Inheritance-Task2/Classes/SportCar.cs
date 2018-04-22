using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            double _fuelConsumption,
            double _engineCapacity,
            ExhaustSystemsBrands _exhaustSystemBrand) 
            : base(_brand, _model, _color, _fuelConsumption, _engineCapacity)
        {
            this.exhaustSystemBrand = _exhaustSystemBrand;
        }

        public override double CalculateFuelConsumption(double averageSpeed)
        {
            throw new NotImplementedException();
        }
    }
}
