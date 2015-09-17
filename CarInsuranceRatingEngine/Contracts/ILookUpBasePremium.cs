using System;
using CarInsuranceRatingEngine.Manufacturers;

namespace CarInsuranceRatingEngine.Contracts
{
    public interface ILookUpBasePremium
    {
        double GetBasePremiumFor(Vehicle vehicle);
    }
}