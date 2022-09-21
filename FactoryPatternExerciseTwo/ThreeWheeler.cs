using System;
namespace FactoryPatternExerciseTwo
{
    public class ThreeWheeler : IVehicle
    {
        public ThreeWheeler()
        {
        }

        public void Drive()
        {
            ConsoleLogger.VehicleStartupDialog();
            Console.WriteLine("Lets get going!");
        }
    }
}

