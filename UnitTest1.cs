using NUnit.Framework;
using CabInvoiceGenerator;


namespace CabInvoiceGeneratorTest
{
    public class Tests
    {
        // InvoiceGenerator Reference.
        InvoiceGenerator invoiceGenerator = null;
        /// <summary>
        /// Test case for checking calculate fare Function
        /// </summary>
        //[SetUp]
        //public void Setup()
        //{
        //}

        [Test]
        public void GivenDistanceAndTimeShouldReturnTotalFare()
        {
            // Creating instance of invoice generator for normal Ride.
            invoiceGenerator = new InvoiceGenerator(RideType.NORMAL);
            double distance = 2.0;
            int time = 5;

            // Calculatig Fare
            double fare = invoiceGenerator.CalculateFare(distance, time);
            double expected = 25;

            //Asserting Values
            Assert.AreEqual(expected, fare);  
        }

        /// <summary>
        /// Test case for checking calculate fare Function for Multiple Rides Summary
        /// </summary>
        [Test]
        public void GivenMultipleRidesShouldReturnInvoiceSummary()
        {
            // Creating instance of invoice generator for normal Ride.
            invoiceGenerator = new InvoiceGenerator(RideType.NORMAL);
            Ride[] rides = { new Ride(2.0, 5), new Ride(0.1, 1) };

            // Generating Summary for Rides
            InvoiceSummary summary = invoiceGenerator.CalculateFare(rides);
            InvoiceSummary expectedSummary = new InvoiceSummary(2, 30.0);

            //Asserting Values
            Assert.AreEqual(expectedSummary, summary);
        }

    }
}