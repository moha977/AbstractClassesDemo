using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleUI
{
  public class Car : Vehicle
    {
        public bool HasTruck { get; set; } = true;

        public override void DriveAbstract()
        {
            Console.WriteLine("Car is Driveable");
        }
    }
}
