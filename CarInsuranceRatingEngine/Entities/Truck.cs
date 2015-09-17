using CarInsuranceRatingEngine.Contracts;

namespace CarInsuranceRatingEngine.Entities
{
    public class Truck : Vehicle
    {
        public Truck(IManufacturer manufacturer) : base(manufacturer) {}
    }
}