using CarInsuranceRatingEngine.Contracts;
using CarInsuranceRatingEngine.Manufacturers;

namespace CarInsuranceRatingEngine.Validators
{
    public class ManufacturerMustExist : IValidateVehicle
    {
        private readonly ILookUpManufacturerFactor _manufacturerStore;

        public ManufacturerMustExist(ILookUpManufacturerFactor manufacturerStore)
        {
            _manufacturerStore = manufacturerStore;
        }

        public void Validate(Vehicle vehicle)
        {
            _manufacturerStore.CheckIfManufacturerExist(vehicle);
        }
    }
}