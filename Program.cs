using System;
using System.Globalization;
using Interface_CSharp.Entites;
using Interface_CSharp.Service;
namespace Interface_CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter rental data: ");
            Console.WriteLine("Car model: ");
            string model = Console.ReadLine();
            Console.WriteLine("PickUp (dd/MM/yyy hh:ss): ");
            DateTime start = DateTime.ParseExact(Console.ReadLine(), "dd / MM / yyyy HH:mm", CultureInfo.InvariantCulture);
            Console.WriteLine("Return (dd/MM/yyy hh:ss): ");
            DateTime finish = DateTime.ParseExact(Console.ReadLine(), "dd / MM / yyyy HH:mm", CultureInfo.InvariantCulture);

            Console.WriteLine("Enter price per hours: ");
            double hour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Enter price per day: ");
            double day = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            CarRental carRent = new CarRental(start, finish, new Vehicle(model));

            RentalService rentalService = new RentalService(hour, day);

            rentalService.ProcessInvoic(carRent);

            Console.WriteLine("INVOICE: ");
            Console.WriteLine(carRent.Invoice);
        }
    }
}
