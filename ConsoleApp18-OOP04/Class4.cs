using System;
using System.Collections.Generic;
using System.Text;
using static ConsoleApp18_OOP04.Class1;

namespace ConsoleApp18_OOP04
{
    internal class ExpressShipment : Shipment

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

                return base.EstimatedCost + Express;
            }
        }





        public override void PrintShipment()
        {
            base.PrintShipment();
            Console.WriteLine($"Extra Fee: {express}");
        }
    }

}
