using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PowerLineTask
{
    abstract internal class Load
    {
        /// <summary>
        /// Максимальная емкость груза в количестве человек или кг в зависимости от типа.
        /// </summary>
        protected ushort maxCapacity;

        /// <summary>
        /// Текущая емкость груза в количестве человек или кг в зависимости от типа.
        /// </summary>
        protected ushort currentCapacity;

        public ushort MaxCapacity
        {
            get => maxCapacity;
        }

        public ushort CurrentCapacity
        {
            get => currentCapacity;
            set
            {
                if (value > maxCapacity)
                {
                    throw new ArgumentException($"Параметр не может быть большим, чем {nameof(maxCapacity)} = {maxCapacity}.", nameof(currentCapacity));
                }
                currentCapacity = value;
            }
        }

        protected Load(ushort maxCapacity, ushort currentCapacity)
        {
            if (currentCapacity > maxCapacity)
            {
                throw new ArgumentException($"Параметр не может быть большим, чем {nameof(maxCapacity)} = {maxCapacity}.", nameof(currentCapacity));
            }
            this.maxCapacity = maxCapacity;
            this.currentCapacity = currentCapacity;
        }

        abstract public float GetDistanceMultiplierDecreaser();
    }
}
