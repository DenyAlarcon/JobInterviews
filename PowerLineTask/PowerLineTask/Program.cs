using System;

namespace PowerLineTask
{
    //public enum CarTypes : byte
    //{
    //    PassengerCar,
    //    Truck,
    //    SportsCar
    //}

    internal class Program
    {
        static void Main(string[] args)
        {
            PassengerLoad pl = new PassengerLoad(4, 2);
            PassengerCar pc = new PassengerCar(12.0F, 70F, 45.3F, 220F, 100F, pl);
            Console.Write(pc);
            Console.WriteLine(pc.GetDistanceOnFuel(true));
            Console.WriteLine(pc.GetDistanceOnFuel());
            pc.PrintCurrentFuelTankVolume();
            Console.WriteLine(pc.GetRoadTime(35F, 157F));
            Console.WriteLine();

            TruckLoad tl = new TruckLoad(800, 313);
            Truck tc = new Truck(19.0F, 120F, 82.8F, 170F, 80F, tl);
            Console.Write(tc);
            Console.WriteLine(tc.GetDistanceOnFuel(true));
            Console.WriteLine(tc.GetDistanceOnFuel());
            tc.PrintCurrentFuelTankVolume();
            Console.WriteLine(tc.GetRoadTime(35F, 157F));
            Console.WriteLine();

            SportsCar sc = new SportsCar(15.0F, 60F, 35.9F, 320F, 120F);
            Console.Write(sc);
            Console.WriteLine(sc.GetDistanceOnFuel(true));
            Console.WriteLine(sc.GetDistanceOnFuel());
            sc.PrintCurrentFuelTankVolume();
            Console.WriteLine(sc.GetRoadTime(35F, 157F));
        }
    }
}
