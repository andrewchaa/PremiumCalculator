using CarInsuranceRatingEngine.Contracts;
using CarInsuranceRatingEngine.Manufacturers;

namespace CarInsuranceRatingEngine.VehicleTypes
{
    public class Car : Vehicle
    {
        public Car(IManufacturer manufacturer) : base(manufacturer) {}
    }
}