using System;
namespace FactoryPatternExerciseTwo
{
    public class Motorcycle : IVehicle
    {
        public Motorcycle()
        {
        }

        public void Drive()
        {
            ConsoleLogger.VehicleStartupDialog();
            Console.WriteLine("The Motorcylce is revving up");
            Console.WriteLine("vroooooooom");
        }
    }
}

