using System.IO;
using CabInvoiceGenerator;

namespace CabInvoiceGeneratorTest
{
    [TestClass]

    public class UnitTest1
    {

        InvoiceGenerator invoiceGenerator;

        [TestMethod]
        public void GivenDistanceAndTimeShouldReturnTotalFare()
        {

            //Arrange
            invoiceGenerator = new InvoiceGenerator(RideType.NORMAL);

            double distance = 2.0;
            int time = 5;
            double expected = 25;

            //Act
            double fare = invoiceGenerator.CalculateFare(distance, time);

            //Assert
            Assert.AreEqual(expected, fare);


        }
    }
}