using CarInsuranceRatingEngine.Contracts;

namespace CarInsuranceRatingEngine.Entities
{
    public class Van : IVehicle
    {
        public string Manufacturer { get; private set; }

        public Van(string manufacturer)
        {
            Manufacturer = manufacturer;
        }

        protected bool Equals(Van other)
        {
            return string.Equals(Manufacturer, other.Manufacturer);
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != this.GetType()) return false;
            return Equals((Van) obj);
        }

        public override int GetHashCode()
        {
            return (Manufacturer != null ? Manufacturer.GetHashCode() : 0);
        }

        public static bool operator ==(Van left, Van right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(Van left, Van right)
        {
            return !Equals(left, right);
        }
    }
}