using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PowerLineTask
{
    internal class SportsCar : Car
    {
        public SportsCar(float averageFuelConsumption, float maxFuelTankVolume, float currentFuelTankVolume, float maxSpeed, float currentSpeed) : base(averageFuelConsumption, maxFuelTankVolume, currentFuelTankVolume, maxSpeed, currentSpeed, null)
        {
            //carType = CarTypes.SportsCar;
        }
    }
}
