using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApplication1
{
    public class Mileage
    {
        //fields--class level variable
        //that describes the class
        private double miles;
        private double gallons;
        private double pricePerGallon;

        //constructor
        public Mileage()
        {
            Miles = 0;
            Gallons = 0;
            PricePerGallon = 0;

        }

        public Mileage(double totalMiles, double totalGallons, double gallonPrice)
        {
            Miles = totalMiles;
            Gallons = totalGallons;
            PricePerGallon = gallonPrice;
        }


        //properties expose private
        //fields to other classes
        //set lets the variable be changed
        //get returns the value of the variable
        public double Miles
        {
            set { miles = value; }
            get { return miles; }
        }

        public double Gallons
        {
            get
            {
                return gallons;
            }

            set
            {
                gallons = value;
            }
        }

        public double PricePerGallon
        {
            get
            {
                return pricePerGallon;
            }

            set
            {
                pricePerGallon = value;
            }
        }

        //public methods
        public double GetMilesPerGallon()
        {
            return Miles / Gallons;
        }

        public double PricePerMile()
        {
            double total = PricePerGallon * Gallons;
            return total / Miles;
        }

        public double GetRange(int gasTankSize)
        {
            return GetMilesPerGallon() * gasTankSize;
        }

    }
}
