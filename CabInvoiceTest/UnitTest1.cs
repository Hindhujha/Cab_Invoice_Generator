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
    }
}