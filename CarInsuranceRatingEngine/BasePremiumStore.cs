using System;
using System.Collections.Generic;
using System.Linq;
using CarInsuranceRatingEngine.Contracts;
using CarInsuranceRatingEngine.Entities;
using CarInsuranceRatingEngine.Exceptions;

namespace CarInsuranceRatingEngine
{
    public class BasePremiumStore : IEnquireBasePremium
    {
        private Dictionary<Type, double> _basePremiums;

        public BasePremiumStore()
        {
            _basePremiums = new Dictionary<Type, double>
            {
                {typeof(Car), 800},
                {typeof(Van), 1000}
            };
        }

        public double GetBasePremiumFor(IVehicle vehicle)
        {
            if (!_basePremiums.Keys.Contains(vehicle.GetType()))
                throw new VehicleTypeNotExistException();

            return _basePremiums[vehicle.GetType()];
        }

    }
}