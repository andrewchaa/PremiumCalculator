using CarInsuranceRatingEngine.Contracts;
using CarInsuranceRatingEngine.Entities;

namespace CarInsuranceRatingEngine
{
    public class PremiumCalculator
    {
        private readonly IEnquireBasePremium _basePremiumStore;

        public PremiumCalculator(IEnquireBasePremium basePremiumStore)
        {
            _basePremiumStore = basePremiumStore;
        }

        public double Calculate(IVehicle vehicle)
        {
            var basePremium = _basePremiumStore.GetBasePremiumFor(vehicle);
            var factor = GetFactorFor(vehicle.Manufacturer);
            return basePremium * factor;
        }

        private double GetFactorFor(string manufacturer)
        {
            return 1.5;
        }

    }
}