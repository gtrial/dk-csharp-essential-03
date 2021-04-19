using System;
namespace task03
{
    public class Plane : Vehicle
    {
        public Plane(double x, double y, decimal price, double speed, DateTime productionDate, double z, int passengerNumber) : base(x, y, price, speed, productionDate)
        {
            Z = z;
            PassengersNumber = passengerNumber;
        }

        public override void PrintDetails()
        {
            base.PrintDetails();
            Console.WriteLine($"Z:{Z}");
            Console.WriteLine($"PassengersNumber:{PassengersNumber}");
        }

        private double Z { get; set; }

        private int PassengersNumber { get; set; }
    }
}
