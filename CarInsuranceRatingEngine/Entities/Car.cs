﻿using CarInsuranceRatingEngine.Contracts;

namespace CarInsuranceRatingEngine.Entities
{
    public class Car : Vehicle
    {
        public Car(IManufacturer manufacturer) : base(manufacturer) {}
    }
}