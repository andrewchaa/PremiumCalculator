using CarInsuranceRatingEngine.Contracts;
using CarInsuranceRatingEngine.Manufacturers;

namespace CarInsuranceRatingEngine.Validators
{
    public class VehicleTypeMustExist : IValidateVehicle
    {
        private readonly ILookUpBasePremium _basePremiumStore;

        public VehicleTypeMustExist(ILookUpBasePremium basePremiumStore)
        {
            _basePremiumStore = basePremiumStore;
        }

        public void Validate(Vehicle vehicle)
        {
            _basePremiumStore.CheckIfVehicleTypeExist(vehicle);
        }
    }
}