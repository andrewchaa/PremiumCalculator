using CarInsuranceRatingEngine.Contracts;

namespace CarInsuranceRatingEngine
{
    public class BasePremiumStore : IEnquireBasePremium
    {
        public double Enquire(string vehicleType)
        {
            return 800;
        }
    }
}