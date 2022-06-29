using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PowerLineTask
{
    internal class PassengerCar : Car
    {
        public ushort MaxPassengersLoad
        {
            get => load.MaxCapacity;
        }

        public ushort CurrentPassengersLoad
        {
            get => load.CurrentCapacity;
        }

        public PassengerCar(float averageFuelConsumption, float maxFuelTankVolume, float currentFuelTankVolume, float maxSpeed, float currentSpeed, PassengerLoad passengersLoad) : base(averageFuelConsumption, maxFuelTankVolume, currentFuelTankVolume, maxSpeed, currentSpeed, passengersLoad)
        {
            //carType = CarTypes.PassengerCar;
            this.load = passengersLoad;
        }
    }
}
