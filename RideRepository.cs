using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CabInvoiceGenerator
{
    public class RideRepository
    {
        // Dictionary to store UserId and Rides int list.
        Dictionary<string, List<Ride>> userRides = null;

        /// Constructor to create Dictionary
        public RideRepository()
        {
            this.userRides = new Dictionary<string, List<Ride>>();
        }

        /// Function to add ride list to Specified User ID
        /// <param name="userId"></param>
        /// <param name="rides"></param>
        public void AddRide(string userId, Ride[] rides)
        {
            bool rideList = this.userRides.ContainsKey(userId);
            try
            {
                if (!rideList)
                {
                    List<Ride> list = new List<Ride>();
                    list.AddRange(rides);
                    this.userRides.Add(userId, list);
                }
            }
            catch (CabInvoiceException)
            {
                throw new CabInvoiceException(CabInvoiceException.ExceptionType.NULL_RIDERS, "Rides Are Null");
            }
        }

        // Function to get Rides list As an Array for specified UserId.
        /// <param name="userId"></param>
        /// <returns></returns>
        public Ride[] GetRides(string userId)
        {
            try
            {
                return this.userRides[userId].ToArray();
            }
            catch (Exception)
            {
                throw new CabInvoiceException(CabInvoiceException.ExceptionType.INVALID_USER_ID, "Invalid User ID");
            }
        }

    }
}
