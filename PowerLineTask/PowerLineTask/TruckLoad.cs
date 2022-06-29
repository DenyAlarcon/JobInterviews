using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PowerLineTask
{
    internal class TruckLoad : Load
    {
        public TruckLoad(ushort maxCapacity, ushort currentCapacity) : base(maxCapacity, currentCapacity)
        {
        }

        public override float GetDistanceMultiplierDecreaser()
        {
            //return MathF.Pow(1 - 0.04F, MathF.Floor(currentCapacity / 200));
            return 1 - 0.04F * MathF.Floor(currentCapacity / 200);
        }
    }
}
