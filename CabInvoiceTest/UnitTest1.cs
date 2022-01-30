using NUnit.Framework;
using Cab_Invoice_Generator;

namespace CabInvoiceTest
{
    public class Tests
    {
        InvoiceGenerator invoiceGenerator = null;

        [Test]
        public void GivenDistanceAndTimeShouldReturnTotalFare()
        {
            invoiceGenerator = new InvoiceGenerator(RideType.NORMAL);
            double distance = 2.0;
            int time = 5;
            //calculating fare
            double fare = invoiceGenerator.CalculateFare(distance, time);
            double expected = 25;

            Assert.AreEqual(expected, fare);
        }

        [Test]
        public void GivenMultipleRidesShouldReturnInvoiceSummary()
        {
            invoiceGenerator =new InvoiceGenerator(RideType.NORMAL);
            Ride[] rides = { new Ride(2, 5), new Ride(0.1, 1) };

            InvoiceSummary summary = invoiceGenerator.CalculateFare(rides);
            InvoiceSummary expectedSummary = new InvoiceSummary(2, 30);

            Assert.AreEqual(expectedSummary, summary);
        }
    }
}