using System;
using System.Collections.Generic;
using System.Text;
using static ConsoleApp18_OOP04.Class1;

namespace ConsoleApp18_OOP04
{

    internal abstract class Shipment
    {
        private string TrackingCode;
        private string Description;
        private decimal Weight;
        private decimal DeliveryFee;
        private DeliveryAddress _destination;


        public DeliveryAddress Destination
        {
            get { return _destination; }
            set { _destination = value; }
        }

        public string trackingCode
        {
            get { return TrackingCode; }


            private set
            {

                if (!string.IsNullOrWhiteSpace(value))
                {
                    TrackingCode = value;
                }
                else
                {
                    Console.WriteLine("Tracking code cannot be empty.");
                }


            }
        }



        public string description
        {
            get { return Description; }


            set

            {
                if (!string.IsNullOrWhiteSpace(value))
                {
                    Description = value;
                }
                else
                {
                    Console.WriteLine("Description cannot be empty.");
                }



            }
        }

        public decimal wight
        {
            get { return Weight; }
            set
            {

                if (value > 0)
                {

                    Weight = value;

                }
                else
                {
                    Console.WriteLine("Weight must be greater than zero.");
                }




            }
        }


        public decimal deliveryFee
        {
            get { return DeliveryFee; }
            private set
            {


                if (value > 0)
                {
                    DeliveryFee = value;
                }

                else
                {
                    Console.WriteLine("Delivery fee must be greater than zero.");
                }




            }
        }

        public abstract decimal EstimatedCost{get; }


        public void UpdateWeight(decimal newWeight)
        {
            wight = newWeight;
        }
        public void UpdateWeight(decimal newWeight, decimal packingWeight)
        {
            wight = newWeight + packingWeight;
        }



        public Shipment(string trackingCode) : this(trackingCode, "Unknown", 1, 50, new DeliveryAddress())
        {


            TrackingCode = trackingCode;
            Description = "Unknown";
            Weight = 1;
            DeliveryFee = 50;
            _destination = new DeliveryAddress();


        }
        public Shipment(string trackingCode, string description, decimal weight, decimal deliveryFee, DeliveryAddress destination)
        {
            TrackingCode = trackingCode;
            Description = description;
            Weight = weight;
            DeliveryFee = deliveryFee;
            _destination = destination;

        }

        public void UpdateDeliveryFee(decimal newFee)
        {
            if (newFee > 0)

            {
                deliveryFee = newFee;

            }


        }

        public abstract void PrintShipment();
        

    }
}
