using System;
namespace Cab_Invoice_Generator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("CAB INVOICE GENERATOR PROBLEMS");
            InvoiceGenerator invoiceGenerator = new InvoiceGenerator(RideType.NORMAL);
            double fare = invoiceGenerator.CalculateFare(2.0, 5);
            Console.WriteLine("FARE IS:", + fare);
        }
    }
}
