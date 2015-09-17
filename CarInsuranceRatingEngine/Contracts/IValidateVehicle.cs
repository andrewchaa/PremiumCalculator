using System;
using CarInsuranceRatingEngine.Manufacturers;

namespace CarInsuranceRatingEngine.Contracts
{
    public interface IValidateVehicle
    {
        void Validate(Vehicle vehicle);
    }
}