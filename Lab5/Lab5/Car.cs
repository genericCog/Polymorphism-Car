using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5
{
    public abstract class BasicCar
    {
        protected ushort CarType;
        public abstract ushort GetCarType();
    }

    class Car : BasicCar
    {
        //protected members
        protected string Make;
        protected ushort Year;
        protected string Color;
        protected decimal Price;
        //protected string HorsePower;

        public Car(string Make, ushort Year, string Color, decimal Price)
        {
            this.Make = Make;
            this.Year = Year;
            this.Color = Color;
            this.Price = Price;
            this.CarType = 1;

        }

        public override ushort GetCarType() { return CarType; }

        public virtual string GetCarInfo()
        {
            return (Make.ToString() + " | " + Year + " | " + Color.ToString() + " | " + Convert.ToString(FormatMoney(Price)));
        }

        public static string FormatMoney(Decimal d)
        {
            return String.Format(CultureInfo.CreateSpecificCulture("en-us"), "{0:C}", d);//http://www.howtogeek.com/howto/programming/format-a-string-as-currency-in-c/
        }

        public class VehicleInitializer
        {
            //make a new class like this one that sets default data if no user input
            private string vehicleMake;
            private ushort vehicleYear;
            private string vehicleColor;
            private decimal vehiclePrice;
            private string vehicleInfo;
            //decimal d;

            public VehicleInitializer()
            {
                vehicleMake = "Volvo";
                vehicleYear = 2000;
                vehicleColor = "Red";
                vehiclePrice = 3000;
                vehicleInfo = vehicleMake + " | " + vehicleYear + " | " + vehicleColor + " | " + Convert.ToString(FormatMoney(vehiclePrice));
            }

            public string Show()
            {
                return (vehicleInfo);
            }
        }
    }

    class SportsCar : Car
    {
        private string HorsePower;

        public SportsCar(string Make, ushort Year, string Color, decimal Price, string horsepower) :
            base(Make, Year, Color, Price)
        {
            HorsePower = horsepower;
            this.CarType = 2;
        }

        public override ushort GetCarType() { return CarType; }

        public override string GetCarInfo()
        {
            return (Make.ToString() + " | " + Year + " | " + Color.ToString() + " | " + Convert.ToString(FormatMoney(Price)) + " | " + HorsePower.ToString());
        }
    }

}
