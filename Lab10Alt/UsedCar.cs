using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab10Alt
{
    class UsedCar : Car
    {
        public double Mileage { get; set; }

        public UsedCar(string make, string model, int year, double price, double mileage)
            : base(make, model, year, price)
        {
            this.Mileage = mileage;
        }
        public override string ToString()
        {
            return base.ToString() + $"\t{this.Mileage}";
        }
    }
}
