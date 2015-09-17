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
        private Dictionary<Type, double> _factors;

        public ManufacturerFactorStore()
        {
            _factors = new Dictionary<Type, double>
            {
                {typeof(Audi), 1.5},
                {typeof(Mercedes), 2.0}
            };
        }

        public double GetFactorFor(IManufacturer manufacturer)
        {
            if (!_factors.Keys.Contains(manufacturer.GetType()))
                throw new ManufacturerNotFoundException();

            return _factors[manufacturer.GetType()];
        }
    }
}