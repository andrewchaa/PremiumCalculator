using CarInsuranceRatingEngine.Contracts;
using CarInsuranceRatingEngine.Manufacturers;

namespace CarInsuranceRatingEngine.VehicleTypes
{
    public class Truck : Vehicle
    {
        public Truck(IManufacturer manufacturer) : base(manufacturer) {}
    }
}