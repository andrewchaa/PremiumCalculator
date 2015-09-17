namespace CarInsuranceRatingEngine.Contracts
{
    public interface ILookUpManufacturerFactor
    {
        double GetFactorFor(IManufacturer manufacturer);
    }
}