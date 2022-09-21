using System;
using System.Threading;

namespace FactoryPatternExerciseTwo
{
    public class ConsoleLogger
    {
        public static void VehicleStartupDialog()
        {
            Console.WriteLine("Put key in ignition");
            Thread.Sleep(1000);
            Console.WriteLine("Turn key");
            Thread.Sleep(1000);
        }
    }
}

