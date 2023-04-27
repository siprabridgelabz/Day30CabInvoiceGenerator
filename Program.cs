namespace CabInvoiceGenerator
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Cab Invoice Generator");
           InvoiceGenerator invoiceGenerator = new InvoiceGenerator(RideType.NORMAL);

           double fare = invoiceGenerator.CalculateFare(2.0, 5);

            Console.WriteLine(fare);

            //int val = (int)Month.Feb;
            //Console.WriteLine(val);
        }

        //enum Month
        //{
        //    Jan=45,
        //    Feb=67,
        //    Mar
        //}
    }
}