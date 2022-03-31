using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CabInvoiceGenerator
{
    /// <summary>
    /// Ride class to Set Data For Particular Ride.
    /// </summary>
    public class Ride
    {
        //Variables
        public double distance;
        public int time;
        
        /// Parameter constructor for setting data
        /// <param name="distance"></param>
        /// <param name="time"></param>
        public Ride (double distance, int time)
        {
            this.distance = distance;
            this.time = time;
        }
    }
}
