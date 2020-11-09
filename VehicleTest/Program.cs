using System;

namespace VehicleTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car(0);
            Console.Write("How much gas do u want to add?: ");
            int amountGas = Convert.ToInt32(Console.ReadLine());
            car.Refuel(amountGas);
            car.Drive();
        }
    }
}
