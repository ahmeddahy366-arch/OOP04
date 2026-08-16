using System;
using System.Collections.Generic;
using System.Text;
using static ConsoleApp18_OOP04.Class1;

namespace ConsoleApp18_OOP04
{
    internal class PriorityInternationalShipment : InternationalShipment
    {
        public PriorityInternationalShipment(
            string trackingCode,
            string description,
            decimal weight,
            decimal deliveryFee,
            string destinationCountry,
            decimal customsFee,
            DeliveryAddress destination)
            : base(
                trackingCode,
                description,
                weight,
                deliveryFee,
                destinationCountry,
                customsFee,
                destination)
        {
        }

        public sealed override void GenerateCustomsReport()
        {
            Console.WriteLine("Priority customs report generated.");
        }
    }
}
