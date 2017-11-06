using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Lab10Alt
{
    class Car
    {
        public Car()
        {
            this.Make = "Fiat";
            this.Model = "500e";
            this.Year = 2017;
            this.Price = 32_975;
        }
        public Car(string make, string model, int year, double price)
        {
            this.Make = make;
            this.Model = model;
            this.Year = year;
            this.Price = price; 
        }

        public string Make { get; set; }

        public string Model { get; set; }

        public int Year { get; set; }

        public double Price { get; set; }      

        public override string ToString()
        {
            return $"{Make}\t{Model}\t{Year}\t${Price}";
        }
    }
       
}
