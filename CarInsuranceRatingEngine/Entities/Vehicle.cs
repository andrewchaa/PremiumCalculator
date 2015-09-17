using CarInsuranceRatingEngine.Contracts;

namespace CarInsuranceRatingEngine.Entities
{
    public abstract class Vehicle
    {
        public IManufacturer Manufacturer { get; private set; }

        protected Vehicle(IManufacturer manufacturer)
        {
            Manufacturer = manufacturer;
        }

        protected bool Equals(Vehicle other)
        {
            return Equals(Manufacturer, other.Manufacturer);
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != this.GetType()) return false;
            return Equals((Vehicle) obj);
        }

        public override int GetHashCode()
        {
            return (Manufacturer != null ? Manufacturer.GetHashCode() : 0);
        }

        public static bool operator ==(Vehicle left, Vehicle right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(Vehicle left, Vehicle right)
        {
            return !Equals(left, right);
        }
    }
}