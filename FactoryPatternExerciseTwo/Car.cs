using System;
namespace FactoryPatternExerciseTwo
{
    public class Car : IVehicle
    {
        public Car()
        {
        }

        public void Drive()
        {
            ConsoleLogger.VehicleStartupDialog();
            Console.WriteLine("The car is driving at a safe pace! Oh boy!");
        }
    }
}

