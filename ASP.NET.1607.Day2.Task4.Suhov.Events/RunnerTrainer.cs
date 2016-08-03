using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASP.NET._1607.Day2.Task4.Suhov.Events
{
    public class RunnerTrainer
    {
        private string _outString;
        /// <summary>
        /// Constructor for creating new instance of class with event manager inside
        /// </summary>
        public RunnerTrainer(BackwardClockManager clock)
        {
            clock.Finished += RunnerMessage;
        }
        /// <summary>
        /// Default constructor without parameters
        /// </summary>
        public RunnerTrainer(){}
        /// <summary>
        /// Method to unregister from event listener
        /// </summary>
        public void Unregister(BackwardClockManager clock)
        {
            clock.Finished -= RunnerMessage;
        }
        /// <summary>
        /// Returns result string describing the object state
        /// </summary>
        public override string ToString()
        {
            return _outString;
        }
        private void RunnerMessage(object sender, BackwardClockEventArgs e)
        {
            _outString = $"The runner sportsmen finished after {e.Seconds} seconds";
        }
    }
}
