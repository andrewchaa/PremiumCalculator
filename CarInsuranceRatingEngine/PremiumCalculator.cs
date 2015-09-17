using CarInsuranceRatingEngine.Contracts;

namespace CarInsuranceRatingEngine
{
    public class PremiumCalculator
    {
        private readonly IEnquireBasePremium _basePremiumStore;

        public PremiumCalculator(IEnquireBasePremium basePremiumStore)
        {
            _basePremiumStore = basePremiumStore;
        }

        public double Calculate(string vehicleType, string manufacturer)
        {
            var basePremium = _basePremiumStore.Enquire(vehicleType);
            var factor = GetFactorFor(manufacturer);
            return basePremium * factor;
        }

        private double GetFactorFor(string manufacturer)
        {
            return 1.5;
        }

    }
}