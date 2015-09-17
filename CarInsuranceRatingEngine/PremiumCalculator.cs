using CarInsuranceRatingEngine.Contracts;
using CarInsuranceRatingEngine.Manufacturers;

namespace CarInsuranceRatingEngine
{
    public class PremiumCalculator
    {
        private readonly ILookUpBasePremium _basePremiumStore;
        private readonly ILookUpManufacturerFactor _manufacturerFactorStore;

        public PremiumCalculator(ILookUpBasePremium basePremiumStore, ILookUpManufacturerFactor manufacturerFactorStore)
        {
            _basePremiumStore = basePremiumStore;
            _manufacturerFactorStore = manufacturerFactorStore;
        }

        public double Calculate(Vehicle vehicle)
        {
            var basePremium = _basePremiumStore.GetBasePremiumFor(vehicle);
            var factor = _manufacturerFactorStore.GetFactorFor(vehicle.Manufacturer);
            
            return basePremium * factor;
        }

    }
}