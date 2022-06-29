using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PowerLineTask
{
    internal class Truck : Car
    {
        public ushort MaxTruckLoad
        {
            get => load.MaxCapacity;
        }

        public ushort CurrentTruckLoad
        {
            get => load.CurrentCapacity;
        }

        public Truck(float averageFuelConsumption, float maxFuelTankVolume, float currentFuelTankVolume, float maxSpeed, float currentSpeed, TruckLoad truckLoad) : base(averageFuelConsumption, maxFuelTankVolume, currentFuelTankVolume, maxSpeed, currentSpeed, truckLoad)
        {
            //carType = CarTypes.Truck;
            this.load = truckLoad;
        }
    }
}
