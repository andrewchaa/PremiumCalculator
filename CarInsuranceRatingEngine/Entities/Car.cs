﻿using CarInsuranceRatingEngine.Contracts;

namespace CarInsuranceRatingEngine.Entities
{
    public class Car : IVehicle
    {
        public string Manufacturer { get; private set; }
        public string VehicleType { get { return "Car"; } }

        public Car(string manufacturer)
        {
            Manufacturer = manufacturer;
        }

        protected bool Equals(Car other)
        {
            return string.Equals(Manufacturer, other.Manufacturer);
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != this.GetType()) return false;
            return Equals((Car) obj);
        }

        public override int GetHashCode()
        {
            return (Manufacturer != null ? Manufacturer.GetHashCode() : 0);
        }

        public static bool operator ==(Car left, Car right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(Car left, Car right)
        {
            return !Equals(left, right);
        }
    }
}