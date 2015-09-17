using CarInsuranceRatingEngine.Contracts;

namespace CarInsuranceRatingEngine.Entities
{
    public class Vehicle : IVehicle
    {
        public IVehicleType VehicleType { get; private set; }
        public IManufacturer Manufacturer { get; private set; }
    }
}
