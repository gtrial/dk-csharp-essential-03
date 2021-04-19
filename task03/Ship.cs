using System;
namespace task03
{
    public class Ship : Vehicle
    {
        public Ship(double x, double y, decimal price, double speed, DateTime productionDate, string port, int passengersNumber) : base(x, y, price, speed, productionDate)
        {
            Port = port;
            PassengersNumber = passengersNumber;
        }

        public override void PrintDetails()
        {
            base.PrintDetails();
            Console.WriteLine($"Port:{Port}");
            Console.WriteLine($"PassengersNumber:{PassengersNumber}");
        }

        private string Port { get; set; }

        private int PassengersNumber { get; set; }
    }
}
