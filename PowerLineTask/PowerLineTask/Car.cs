using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PowerLineTask
{
    abstract internal class Car
    {
        ///// <summary>
        ///// Тип автомобиля.
        ///// </summary>
        //protected CarTypes carType;

        /// <summary>
        /// Средний расхода топлива в литрах/100 км.
        /// </summary>
        protected float averageFuelConsumption;

        /// <summary>
        /// Максимальный объем топливного бака в литрах.
        /// </summary>
        protected float maxFuelTankVolume;

        /// <summary>
        /// Текущий объем топливного бака в литрах.
        /// </summary>
        protected float currentFuelTankVolume;

        /// <summary>
        /// Максимальная скорость в км/ч.
        /// </summary>
        protected float maxSpeed;

        /// <summary>
        /// Текущая скорость в км/ч.
        /// </summary>
        protected float currentSpeed;

        /// <summary>
        /// Груз в количестве человек или в кг в зависимости от типа.
        /// </summary>
        protected Load load;

        public float AverageFuelConsumption
        {
            get => averageFuelConsumption;
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Параметр не может быть отрицательным.", nameof(AverageFuelConsumption));
                }
                averageFuelConsumption = value;
            }
        }

        public float MaxFuelTankVolume
        {
            get => maxFuelTankVolume;
        }

        public float CurrentFuelTankVolume
        {
            get => currentFuelTankVolume;
            set
            {
                if (value < 0 || value > maxFuelTankVolume)
                {
                    throw new ArgumentException($"Параметр не может быть отрицательным или большим, чем {nameof(maxFuelTankVolume)} = {maxFuelTankVolume}.", nameof(CurrentFuelTankVolume));
                }
                currentFuelTankVolume = value;
            }
        }

        public float MaxSpeed
        {
            get => maxSpeed;
        }

        public float CurrentSpeed
        {
            get => currentSpeed;
            set
            {
                if (value < 0 || value > maxSpeed)
                {
                    throw new ArgumentException($"Параметр не может быть отрицательным или большим, чем {nameof(maxSpeed)} = {maxSpeed}.", nameof(CurrentSpeed));
                }
                currentSpeed = value;
            }
        }

        protected Car(float averageFuelConsumption, float maxFuelTankVolume, float currentFuelTankVolume, float maxSpeed, float currentSpeed, Load load)
        {
            if (averageFuelConsumption < 0)
            {
                throw new ArgumentException("Параметр не может быть отрицательным.", nameof(averageFuelConsumption));
            }
            if (maxFuelTankVolume < 0)
            {
                throw new ArgumentException("Параметр не может быть отрицательным.", nameof(maxFuelTankVolume));
            }
            if (currentFuelTankVolume < 0 || currentFuelTankVolume > maxFuelTankVolume)
            {
                throw new ArgumentException($"Параметр не может быть отрицательным или большим, чем {nameof(maxFuelTankVolume)} = {maxFuelTankVolume}.", nameof(currentFuelTankVolume));
            }
            if (maxSpeed < 0)
            {
                throw new ArgumentException("Параметр не может быть отрицательным.", nameof(maxSpeed));
            }
            if (currentSpeed < 0 || currentSpeed > maxSpeed)
            {
                throw new ArgumentException($"Параметр не может быть отрицательным или большим, чем {nameof(maxSpeed)} = {maxSpeed}.", nameof(currentSpeed));
            }
            this.averageFuelConsumption = averageFuelConsumption;
            this.maxFuelTankVolume = maxFuelTankVolume;
            this.currentFuelTankVolume = currentFuelTankVolume;
            this.maxSpeed = maxSpeed;
            this.currentSpeed = currentSpeed;
            this.load = load;
        }

        /// <summary>
        /// Вычисление расстояния в км, которое может проехать автомобиль на текущем или полном баке топлива.
        /// </summary>
        /// <param name="calculateForMaxFuel">
        /// Для какой емкости бака вычислить расстояние, true - для полного бака, false - для текущего бака.
        /// </param>
        /// <returns>
        /// Расстояние в км, которое может проехать автомобиль на текущем или полном баке топлива.
        /// </returns>
        public float GetDistanceOnFuel(bool calculateForMaxFuel = false)
        {
            float fuelTankVolume = calculateForMaxFuel ? maxFuelTankVolume : currentFuelTankVolume;
            float distance = fuelTankVolume / averageFuelConsumption * 100;
            if (load is not null)
            {
                distance *= load.GetDistanceMultiplierDecreaser();
            }
            return distance;
        }

        /// <summary>
        /// Отображение текущей информации о состоянии запаса хода в зависимости от пассажиров и груза.
        /// </summary>
        public void PrintCurrentFuelTankVolume()
        {
            Console.WriteLine($"Текущий запас хода: {GetDistanceOnFuel():F2} км.");
        }

        /// <summary>
        /// Метод, который на основе параметров количества топлива и заданного расстояния вычисляет за сколько автомобиль его преодолеет в часах.
        /// </summary>
        /// <param name="fuelValue">
        /// Количество топлива в литрах.
        /// </param>
        /// <param name="distance">
        /// Расстояние в км.
        /// </param>
        /// <returns>
        /// Время в часах, которое потребуется автомобилю, чтобы проехать указанное расстояние при заданном количестве топлива. Вовращает 0, если при указанном параметре запаса топлива автомобиль не сможет проехать заданное расстояние.
        /// </returns>
        /// <exception cref="System.ArgumentException">
        /// Выбрасывается, когда один из параметров отрицательный или равен нулю, а также когда первый параметр, характеризующий емкость бака, больше максимального значения емкости бака для данного автомобиля.
        /// </exception>
        public float GetRoadTime(float fuelValue, float distance)
        {
            if (fuelValue <= 0 || fuelValue > maxFuelTankVolume)
            {
                throw new ArgumentException($"Параметр не может быть отрицательным, равным нулю или большим чем {nameof(maxFuelTankVolume)} = {maxFuelTankVolume}.", nameof(fuelValue));;
            }
            if (distance <= 0)
            {
                throw new ArgumentException("Параметр не может быть отрицательным или равным нулю.", nameof(distance));
            }

            float maxRoadDistance = fuelValue / averageFuelConsumption * 100;
            if (load is not null)
            {
                maxRoadDistance *= load.GetDistanceMultiplierDecreaser();
            }

            if (maxRoadDistance < distance)
            {
                return 0;
            }

            return distance / currentSpeed;
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            //result.Append($"carType: {carType}\n");
            result.Append($"{nameof(averageFuelConsumption)}: {averageFuelConsumption:F2}\n");
            result.Append($"{nameof(maxFuelTankVolume)}: {maxFuelTankVolume:F2}\n");
            result.Append($"{nameof(currentFuelTankVolume)}: {currentFuelTankVolume:F2}\n");
            result.Append($"{nameof(maxSpeed)}: {maxSpeed:F2}\n");
            result.Append($"{nameof(currentSpeed)}: {currentSpeed:F2}\n");
            if (load is not null)
            {
                result.Append($"{nameof(load.MaxCapacity)}: {load.MaxCapacity}\n");
                result.Append($"{nameof(load.CurrentCapacity)}: {load.CurrentCapacity}\n");
            }
            return result.ToString();
        }
    }
}
