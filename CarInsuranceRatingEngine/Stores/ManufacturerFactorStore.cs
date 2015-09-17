using System;
using System.Collections.Generic;
using System.Linq;
using CarInsuranceRatingEngine.Contracts;
using CarInsuranceRatingEngine.Exceptions;
using CarInsuranceRatingEngine.Manufacturers;

namespace CarInsuranceRatingEngine.Stores
{
    public class ManufacturerFactorStore : ILookUpManufacturerFactor
    {
        private readonly Dictionary<Type, double> _factors;

        public ManufacturerFactorStore()
        {
            _factors = new Dictionary<Type, double>
            {
                {typeof(Audi), 1.5},
                {typeof(Mercedes), 2.0}
            };
        }

        public double GetFactorFor(Vehicle vehicle)
        {
            CheckIfManufacturerExist(vehicle);
            return _factors[vehicle.Manufacturer.GetType()];
        }

        public void CheckIfManufacturerExist(Vehicle vehicle)
        {
            if (!_factors.Keys.Contains(vehicle.Manufacturer.GetType()))
                throw new ManufacturerNotFoundException();
        }
    }
}