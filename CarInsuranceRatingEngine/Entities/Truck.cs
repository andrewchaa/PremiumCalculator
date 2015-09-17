using CarInsuranceRatingEngine.Contracts;

namespace CarInsuranceRatingEngine.Entities
{
    public class Truck : IVehicle
    {
        public string Manufacturer { get; private set; }

        public Truck(string manufacturer)
        {
            Manufacturer = manufacturer;
        }

        protected bool Equals(Truck other)
        {
            return string.Equals(Manufacturer, other.Manufacturer);
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != this.GetType()) return false;
            return Equals((Truck) obj);
        }

        public override int GetHashCode()
        {
            return (Manufacturer != null ? Manufacturer.GetHashCode() : 0);
        }

        public static bool operator ==(Truck left, Truck right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(Truck left, Truck right)
        {
            return !Equals(left, right);
        }
    }
}