using System;
using System.Collections.Generic;
using System.Text;
using static ConsoleApp18_OOP04.Class1;

namespace ConsoleApp18_OOP04
{
    internal sealed class CompletedShipment : Shipment
    {
        public CompletedShipment(string trackingCode, string description, decimal weight, decimal deliveryFee, DeliveryAddress destination)
            : base(trackingCode, description, weight, deliveryFee, destination)
        {
        }
        public override void PrintShipment()
        {
            base.PrintShipment();
        }
    }

}
