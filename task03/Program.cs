using System;

namespace task03
{
    internal static class Program
    {
        private static void Main()
        {
            var plane = new Plane(100, 200, 10000000, 1000, DateTime.Now, 10000, 200);
            var car = new Саг(200, 300, 15000, 200, DateTime.Now);
            var ship = new Ship(300, 400, 5000000, 30, DateTime.Now, "Port", 1000);

            plane.PrintDetails();
            car.PrintDetails();
            ship.PrintDetails();
        }
    }
}
