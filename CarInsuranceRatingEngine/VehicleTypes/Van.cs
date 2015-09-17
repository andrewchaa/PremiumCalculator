using CarInsuranceRatingEngine.Contracts;
using CarInsuranceRatingEngine.Manufacturers;

namespace CarInsuranceRatingEngine.VehicleTypes
{
    public class Van : Vehicle
    {
        public Van(IManufacturer manufacturer) : base(manufacturer) {}
    }
}