using System.Collections;
using System.Collections.Generic;
using CarInsuranceRatingEngine.Contracts;
using CarInsuranceRatingEngine.Manufacturers;

namespace CarInsuranceRatingEngine
{
    public class PremiumCalculator
    {
        private readonly ILookUpBasePremium _basePremiumStore;
        private readonly ILookUpManufacturerFactor _manufacturerFactorStore;
        private readonly IEnumerable<IValidateVehicle> _validators;

        public PremiumCalculator(ILookUpBasePremium basePremiumStore, ILookUpManufacturerFactor manufacturerFactorStore, IEnumerable<IValidateVehicle> validators)
        {
            _basePremiumStore = basePremiumStore;
            _manufacturerFactorStore = manufacturerFactorStore;
            _validators = validators;
        }

        public double Calculate(Vehicle vehicle)
        {
            foreach (var validator in _validators)
            {
                validator.Validate(vehicle);
            }

            var basePremium = _basePremiumStore.GetBasePremiumFor(vehicle);
            var factor = _manufacturerFactorStore.GetFactorFor(vehicle);
            
            return basePremium * factor;
        }

    }
}