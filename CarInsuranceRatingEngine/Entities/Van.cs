using CarInsuranceRatingEngine.Contracts;

namespace CarInsuranceRatingEngine.Entities
{
    public class Van : Vehicle
    {
        public Van(IManufacturer manufacturer) : base(manufacturer) {}
    }
}