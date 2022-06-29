using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PowerLineTask
{
    internal class PassengerLoad : Load
    {
        public PassengerLoad(ushort maxCapacity, ushort currentCapacity) : base(maxCapacity, currentCapacity)
        {
        }

        public override float GetDistanceMultiplierDecreaser()
        {
            //return MathF.Pow(1 - 0.06F, currentCapacity);
            return 1 - 0.06F * currentCapacity;
        }
    }
}
