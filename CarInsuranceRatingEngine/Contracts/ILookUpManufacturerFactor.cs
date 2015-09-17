using CarInsuranceRatingEngine.Manufacturers;

namespace CarInsuranceRatingEngine.Contracts
{
    public interface ILookUpManufacturerFactor
    {
        double GetFactorFor(Vehicle manufacturer);
        void CheckIfManufacturerExist(Vehicle vehicle);
    }
}