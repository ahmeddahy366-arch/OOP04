using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp18_OOP04
{
    internal class DeliveryCenter
    {
        private Shipment[] Shipments = new Shipment[20];

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
                    return Shipments[index];

                return null;





            }
            set
            {

                if (index >= 0 && index < Shipments.Length)
                    Shipments[index] = value;




            }





        }
        public Shipment this[string TrackingCode]


        {


            get
            {

                foreach (var s in Shipments)


                {
                    if (s != null && s.trackingCode == TrackingCode)
                        return s;
                }
                return null;
            }


        }
        public bool AddShipment(Shipment shipment)
        {
            for (int i = 0; i < Shipments.Length; i++)
            {
                if (Shipments[i] == null)
                {
                    Shipments[i] = shipment;
                    return true;
                }

            }

            return false;





        }

        public bool RemoveShipment(string TrackingCode)
        {


            for (int i = 0; i < Shipments.Length; i++)

            {

                if (Shipments[i] != null && Shipments[i].trackingCode == TrackingCode)
                {
                    Shipments[i] = null;
                    return true;
                }

            }
            return false;


        }

        public void PrintAllShipments()
        {


            for (int i = 0; i < Shipments.Length; i++)
            {
                if (Shipments[i] != null)
                {
                    Shipments[i].PrintShipment();
                }
            }
        }
        
           public void PrintTrackingStatuses()
        {
            foreach (ITrackable t in Shipments)
            {
                t.GetTrackingStatus();
            }
        }
        public void PrintCalculateInsurance()
        {
            foreach(IInsurable I in Shipments)
            {
                I.CalculateInsurance();
            }
        }
    }





}




}
