namespace CarInsuranceRatingEngine.Contracts
{
    public interface IVehicle
    {
        IVehicleType VehicleType { get; }
        IManufacturer Manufacturer { get; }
    }
}