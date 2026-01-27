using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_HW
{
    partial class Freezer
    {
        static Freezer()
        {
            total = 0;
            maxtemp = -18.0;
        }
        public Freezer()
        {
            brand = "Unknown";
            capL = 100;
            manuDate = DateTime.Now;
            isOn = false;
            temp = maxtemp;

            total++;
        }
        public Freezer(string brand, int capacityLiters)
        {
            this.brand = brand;
            this.capL = capacityLiters;
            manuDate = DateTime.Now;
            isOn = false;
            temp = maxtemp;

            total++;
        }
        public Freezer(string brand, int capacityLiters, DateTime manufactureDate, bool isOn)
        {
            this.brand = brand;
            this.capL = capacityLiters;
            this.manuDate = manufactureDate;
            this.isOn = isOn;
            this.temp = maxtemp;

            total++;
        }

        
        public override string ToString()
        {
            return $"Brand: {brand}, " +
                   $"Capacity: {capL} л, " +
                   $"Temperature: {temp} °C, " +
                   $"State: {(isOn ? "On" : "Off")}, " +
                   $"Manufacture Date: {manuDate.ToShortDateString()}";
        }
    }
}
