using System;
using System.Collections.Generic;
using System.Linq;
using CarInsuranceRatingEngine.Contracts;
using CarInsuranceRatingEngine.Exceptions;
using CarInsuranceRatingEngine.Manufacturers;
using CarInsuranceRatingEngine.VehicleTypes;

namespace CarInsuranceRatingEngine.Stores
{
    public class BasePremiumStore : ILookUpBasePremium
    {
        private readonly Dictionary<Type, double> _basePremiums;

        public BasePremiumStore()
        {
            _basePremiums = new Dictionary<Type, double>
            {
                {typeof(Car), 800},
                {typeof(Van), 1000}
            };
        }

        public void CheckIfVehicleTypeExist(Vehicle vehicle)
        {
            if (!_basePremiums.Keys.Contains(vehicle.GetType()))
                throw new VehicleTypeNotExistException();
        }

        public double GetBasePremiumFor(Vehicle vehicle)
        {
            CheckIfVehicleTypeExist(vehicle);

            return _basePremiums[vehicle.GetType()];
        }

    }
}