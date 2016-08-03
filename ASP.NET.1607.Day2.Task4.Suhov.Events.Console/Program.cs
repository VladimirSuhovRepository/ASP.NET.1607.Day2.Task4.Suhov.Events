using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASP.NET._1607.Day2.Task4.Suhov.Events.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            var manager = new BackwardClockManager();
            var swimmer = new SwimmerTrainer(manager);
            var runner = new RunnerTrainer(manager);
            System.Console.WriteLine("Please, enter the seconds number:");
            int seconds;
            Int32.TryParse(System.Console.ReadLine(),out seconds);
            manager.StartBackwardClock(seconds);
            System.Console.WriteLine(swimmer.ToString());
            System.Console.WriteLine(runner.ToString());
            System.Console.ReadKey();
        }
    }
}
