namespace CarInsuranceRatingEngine.Contracts
{
    public interface IEnquireBasePremium
    {
        double GetBasePremiumFor(string vehicleType);
    }
}