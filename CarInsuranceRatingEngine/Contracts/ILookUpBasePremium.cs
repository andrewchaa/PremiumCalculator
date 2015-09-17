using System;
using CarInsuranceRatingEngine.Entities;

namespace CarInsuranceRatingEngine.Contracts
{
    public interface ILookUpBasePremium
    {
        double GetBasePremiumFor(Vehicle vehicle);
    }
}