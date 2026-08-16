using System;
using System.Collections.Generic;
using System.Text;
using static ConsoleApp18_OOP04.Class1;

namespace ConsoleApp18_OOP04
{
    internal class InternationalShipment : Shipment,IInsurable,ITrackable
    {
        public InternationalShipment(string trackingCode, string description, decimal weight, decimal deliveryFee, string destinationCountry, decimal customsFee, DeliveryAddress destination)
            : base(trackingCode, description, weight, deliveryFee, destination)
        {
            DestinationCountry = destinationCountry;
            CustomsFee = customsFee;

        }
        private string destinationCountry;
        private decimal customsFee;



        public string DestinationCountry
        {
            get { return destinationCountry; }
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                {

                    destinationCountry = value;


                }

            }

        }

        public decimal CustomsFee
        {
            get { return customsFee; }
            set
            {

                if (value >= 0)
                {

                    customsFee = value;


                }
            }


        }
        public override decimal EstimatedCost
        {
            get { return deliveryFee + customsFee; }

        }
        public override void PrintShipment()
        {
            Console.WriteLine($"Tracking Code: {TrackingCode}, Cost: {EstimatedCost}");
            Console.WriteLine($"Destination Country: {destinationCountry}");
            Console.WriteLine($"Customs Fee: {customsFee}");
        }
        public virtual void GenerateCustomsReport()
        {
            Console.WriteLine("Generating Customs Report...");
        }

        public string GetTrackingStatus()
        {
            return $"Shipment {TrackingCode} is currently in transit.";
        }

        public decimal CalculateInsurance()
        {
            return EstimatedCost * 0.12m;
        }
    }
}
