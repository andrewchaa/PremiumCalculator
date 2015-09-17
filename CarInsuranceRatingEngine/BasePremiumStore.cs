using System.Collections.Generic;
using System.Linq;
using CarInsuranceRatingEngine.Contracts;
using CarInsuranceRatingEngine.Exceptions;

namespace CarInsuranceRatingEngine
{
    public class BasePremiumStore : IEnquireBasePremium
    {
        private Dictionary<string, double> _basePremiums;

        public BasePremiumStore()
        {
            _basePremiums = new Dictionary<string, double>
            {
                {"Car", 800},
                {"Van", 1000}
            };
        }

        public double GetBasePremiumFor(string vehicleType)
        {
            if (!_basePremiums.Keys.Contains(vehicleType))
                throw new VehicleTypeNotExistException();

            return _basePremiums[vehicleType];
        }

    }
}