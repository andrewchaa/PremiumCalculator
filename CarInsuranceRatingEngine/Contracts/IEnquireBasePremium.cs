using System;
using CarInsuranceRatingEngine.Entities;

namespace CarInsuranceRatingEngine.Contracts
{
    public interface IEnquireBasePremium
    {
        double GetBasePremiumFor(Vehicle vehicle);
    }
}