using System;
using System.Collections.Generic;
using System.Text;
using static ConsoleApp18_OOP04.Class1

namespace ConsoleApp18_OOP04
{
    internal class ExpressShipment : Shipment,ITrackable, IInsurable

    {
        public ExpressShipment(string trackingCode, string description, decimal weight, decimal deliveryFee, decimal express, DeliveryAddress destination)
            : base(trackingCode, description, weight, deliveryFee, destination)
        {
            Express = express;


        }
        private decimal express;

        public decimal Express
        {
            get { return express; }
            set
            {
                if (value >= 0)
                {
                    express = value;
                }


            }
        }

        public override decimal EstimatedCost
        {
            get
            {

                return deliveryFee + Express;
            }
        }





        public override void PrintShipment()
        {
            Console.WriteLine($"Tracking Code: {TrackingCode}, Cost: {EstimatedCost}");
            Console.WriteLine($"Extra Fee: {express}");
        }

        public string GetTrackingStatus()
        {
            return $"Shipment {TrackingCode} is currently in transit.";

        }

        public decimal CalculateInsurance()
        {
            return EstimatedCost * 0.08m;
        }
    }

}
