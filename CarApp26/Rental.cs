using System;
using System.Collections.Generic;
using System.Text;

namespace CarApp26
{
    public class Rental
    {
        private const int PricePerDay = 100;
        private const int PricePerKm = 2;

        public Car Car { get; }
        public Renter Renter { get; }
        public DateTime StartDate { get; private set; }
        public DateTime EndDate { get; private set; }
        public int StartOdometer { get; private set; }
        public int EndOdometer { get; private set; }

        public Rental(Car car, Renter renter)
        {
            Car = car;
            Renter = renter;
            StartOdometer = Car.Odometer;
            StartDate = DateTime.Now; //Sætter dato tid lige nu
        }

        public void EndRental()
        {
            EndDate = DateTime.Now;
            EndOdometer = Car.Odometer;
        }

        public double CalculatePrice()
        {
            int numBerOfDays = (EndDate - StartDate).Days +1;
            int numberOfKm = EndOdometer - StartOdometer;

            return numBerOfDays * PricePerDay + numberOfKm * PricePerKm;
        }


        public void PrintReceipt()
        {
            Console.WriteLine("---- Receipt for rental");
            //Udskriv bilens model og registreringsnummer
            Console.WriteLine($"Model {Car.Model} {Car.RegNo} " );
            //Udskriv navn på ejer

            Console.WriteLine($"Ejer {Car.TheOwner.Name} ");
            //Udskriv navn på lejer 
            Console.WriteLine($"Lejer { Renter.Name }");
            //Udskriv startdato og slutdato
            Console.WriteLine($"Startdato {StartDate.ToShortDateString() }slutdato {EndDate}");
            //Antal km kørt
            Console.WriteLine($"Antal km {EndOdometer -StartOdometer }");
            //Udskriv prisen
            Console.WriteLine($"Prisen er {CalculatePrice() }");


        }

    }
}
