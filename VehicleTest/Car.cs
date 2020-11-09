using System;

namespace VehicleTest
{
    public class Car : IVehiculo
    {
        public int StartingGas{get; set;}
        public Car(int startingGas)
        {
           StartingGas = startingGas; 
        }

        public void Drive()
        {
            if (StartingGas > 0)
            {
                Console.WriteLine("The Car is Driving");
            } else
            {
                throw new Exception("Car needs gasoline to drive");
            }
        }
        public bool Refuel(int amountGas)
        {
            StartingGas = StartingGas + amountGas;
            return true;
        }
    }
}