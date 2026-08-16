using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp18_OOP04
{
    internal class DeliveryCenter
    {
        private Shipment[] Shipment = new Shipment[20];

        public Driver Driver { get; set; }
        private string centerName;

        public string CenterName
        {
            get { return centerName; }
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                    centerName = value;
            }
        }
        public Shipment this[int index]

        {


            get
            {

                if (index >= 0 && index < Shipment.Length)
                    return Shipment[index];

                return null;





            }
            set
            {

                if (index >= 0 && index < Shipment.Length)
                    Shipment[index] = value;




            }





        }
        public Shipment this[string TrackingCode]


        {


            get
            {

                foreach (var s in Shipment)


                {
                    if (s != null && s.trackingCode == TrackingCode)
                        return s;
                }
                return null;
            }


        }
        public bool AddShipment(Shipment shipment)
        {
            for (int i = 0; i < Shipment.Length; i++)
            {
                if (Shipment[i] == null)
                {
                    Shipment[i] = shipment;
                    return true;
                }

            }

            return false;





        }

        public bool RemoveShipment(string TrackingCode)
        {


            for (int i = 0; i < Shipment.Length; i++)

            {

                if (Shipment[i] != null && Shipment[i].trackingCode == TrackingCode)
                {
                    Shipment[i] = null;
                    return true;
                }

            }
            return false;


        }

        public void PrintAllShipments()
        {


            for (int i = 0; i < Shipment.Length; i++)
            {
                if (Shipment[i] != null)
                {
                    Shipment[i].PrintShipment();
                }
            }
        }





    }




}
