using System;
namespace task03
{
    public class Vehicle
    {
        protected Vehicle(double x, double y, decimal price, double speed, DateTime productionDate)
        {
            X = x;
            Y = y;
            Price = price;
            Speed = speed;
            ProductionDate = productionDate;
        }

        public virtual void PrintDetails()
        {
            Console.WriteLine(this.GetType().ToString());
            Console.WriteLine($"X:{X}");
            Console.WriteLine($"Y:{Y}");
            Console.WriteLine($"Price:{Price}");
            Console.WriteLine($"Speed:{Speed}");
            Console.WriteLine($"ProductionDate:{ProductionDate}");
        }

        private double X { get; set; }

        private double Y { get; set; }

        private decimal Price { get; set; }

        private double Speed { get; set; }

        private DateTime ProductionDate { get; set; }
    }
}
