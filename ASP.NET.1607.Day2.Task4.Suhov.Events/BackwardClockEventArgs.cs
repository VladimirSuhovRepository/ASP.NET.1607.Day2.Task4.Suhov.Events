using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASP.NET._1607.Day2.Task4.Suhov.Events
{
    public class BackwardClockEventArgs:EventArgs
    {
        /// <summary>
        /// Constructor for custom EventArgs class
        /// </summary>
        public BackwardClockEventArgs(int seconds)
            :base()
        {
            Seconds = seconds;
        }
        /// <summary>
        /// Return seconds which is used to be backwarded
        /// </summary>
        public int Seconds { get; private set; }
    }
}
