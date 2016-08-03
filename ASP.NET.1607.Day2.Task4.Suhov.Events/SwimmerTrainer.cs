using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASP.NET._1607.Day2.Task4.Suhov.Events
{
    public class SwimmerTrainer
    {
        private string _outString;
        /// <summary>
        /// Constructor for creating new instance of class with event manager inside
        /// </summary>
        public SwimmerTrainer(BackwardClockManager clock)
        {
            clock.Finished += SwimmingMessage;
        }
        /// <summary>
        /// Default constructor without parameters
        /// </summary>
        public SwimmerTrainer(){}
        public void Unregister(BackwardClockManager clock)
        {
            clock.Finished -= SwimmingMessage;
        }
        /// <summary>
        /// Method to unregister from event listener
        /// </summary>
        public override string ToString()
        {
            return _outString;
        }
        /// <summary>
        /// Returns result string describing the object state
        /// </summary>
        private void SwimmingMessage(object sender, BackwardClockEventArgs e)
        {
            _outString = $"The swiming sportsmen finished after {e.Seconds} seconds";
        }
    }
}
