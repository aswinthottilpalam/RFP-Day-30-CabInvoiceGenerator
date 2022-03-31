using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CabInvoiceGenerator
{
    public class InvoiceSummary
    {
        //Variables
        private int numberOFRides;
        private double totalFare;
        private double averageFare;

        /// <summary>
        /// Parameter Constructor For Setting Data
        /// </summary>
        /// <param name="numberOfRides"></param>
        /// <param name="totalFare"></param>
        public InvoiceSummary(int numberOfRides, double totalFare)
        {
            //Setting Data
            this.numberOFRides = numberOfRides;
            this.totalFare = totalFare;
            this.averageFare = this.totalFare / this.numberOFRides;
        }

        /// OverRiding Equal method.
        /// <param name="obj"></param>
        /// <returns></returns>
        public override bool Equals(object obj)
        {
            if (obj == null) return false;
            if (!(obj is InvoiceSummary)) return false;

            InvoiceSummary inputedObject = (InvoiceSummary)obj;
            return this.numberOFRides == inputedObject.numberOFRides && this.totalFare == inputedObject.totalFare && this.averageFare == inputedObject.averageFare;

        }

        /// OverRiding GetHash Method
        /// <returns></returns>
        public override int GetHashCode()
        {
            return this.numberOFRides.GetHashCode() ^ this.totalFare.GetHashCode() ^ this.averageFare.GetHashCode();
        }
    }
}
