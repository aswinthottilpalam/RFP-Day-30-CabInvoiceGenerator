using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CabInvoiceGenerator
{
    /// <summary>
    /// Class for Custom exception handling.
    /// </summary>
    public class CabInvoiceException : Exception
    {
        /// Enum for Exception type
        public enum ExceptionType
        {
            INVALID_RIDE_TYPE,
            INVALID_DISTANCE,
            INVALID_TIME,
            NULL_RIDERS,
            INVALID_USER_ID,
            NULL_RIDES
        }
        ExceptionType type;

        /// Parameter constructor for setting exception type and throwing exception.
        /// <param name="type"></param>
        /// <param name="message"></param>
        public CabInvoiceException(ExceptionType type, string massage) : base(message)
        {
            this.type = type;
        }

    }
}
