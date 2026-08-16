using ConsoleApp18_OOP04;
using System.Net;

namespace ConsoleApp18_OOP04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StandardShipment standard = new StandardShipment("SH001", "Cairo", 10.0m, 100.0m,10,new DeliveryAddress());
            ExpressShipment express = new ExpressShipment("SH002", "Alexandria", 5.0m, 200.0m, 50.0m,new DeliveryAddress());
            InternationalShipment international = new InternationalShipment("SH003", "Giza", 8.0m, 300.0m, "USA", 15.0m, new DeliveryAddress());
            DeliveryCenter center = new DeliveryCenter();
            center.AddShipment(standard);
            center.AddShipment(express);
            center.AddShipment(international);
            Console.WriteLine("=== All Shipment Details ===");
            standard.PrintShipment();
            express.PrintShipment();
            international.PrintShipment();

            center.PrintTrackingStatuses();
            Console.WriteLine("\n=== Insurance Costs ===");
            DeliveryReport.PrintInsurance(standard);
            DeliveryReport.PrintInsurance(express);
            DeliveryReport.PrintInsurance(international);
        }
    }
  
}
#region question1
//a)  What is Abstraction in Object-Oriented Programming?
//Abstraction in OOP is the concept of hiding complex internal
//implementation details and exposing only the essential features of an object to the user.
//b)  Why is abstraction considered one of the four pillars of OOP?
//؟؟؟؟؟؟؟؟؟؟؟؟؟؟؟؟؟؟؟؟؟؟؟؟؟؟؟؟؟؟؟؟؟؟؟؟؟؟؟؟؟؟؟؟؟


#endregion
#region question2
//a)  What is the difference between an Abstract Class and an Interface?
//Abstract Class: Represents an "is-a" relationship with shared code, fields, and constructors, but supports only single inheritance.
//Interface: Represents a "can-do" capability defining a strict contract without fields or constructors, supporting multiple inheritance.
//b)  When would you choose an Interface instead of an Abstract Class?
//Multiple Inheritance: A class needs to adopt multiple behaviors,
//as C# supports implementing multiple interfaces but inheriting from only one base class.
//Defining Capabilities ("can-do")
//No Shared State / Code: You only need to enforce a behavioral contract without sharing instance fields, state, or default code logic.
//c)  Can a class inherit from multiple abstract classes? Can it implement multiple interfaces?
//Multiple Abstract Classes: No.C# does not support multiple class inheritance.
//Multiple Interfaces: Yes.A single class can implement multiple interfaces at the same time.
    #endregion
