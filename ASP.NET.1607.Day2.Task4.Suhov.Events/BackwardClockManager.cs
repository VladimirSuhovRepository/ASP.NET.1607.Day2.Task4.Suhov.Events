using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ASP.NET._1607.Day2.Task4.Suhov.Events
{
    public class BackwardClockManager
    {
        /// <summary>
        /// Delcare delegate for Event handler
        /// </summary>
        public delegate void BackwardClockEventHandler<T>(object sender, BackwardClockEventArgs e);
        /// <summary>
        /// Event for delegate to make grouping subscriptions
        /// </summary>
        public event BackwardClockEventHandler<int> Finished = delegate { }; 
        /// <summary>
        /// Method that invokes event delegate
        /// </summary>
        protected virtual void OnFinished(object sender, BackwardClockEventArgs e)
        {
            Finished?.Invoke(sender,e);
        }
        /// <summary>
        /// Method for initiate backward clock with parameterd
        /// </summary>
        public void StartBackwardClock(int seconds)
        {
            for (int i = seconds; i != 0; i--) Thread.Sleep(1000);
            OnFinished(this, new BackwardClockEventArgs(seconds));
        }
    }
}
