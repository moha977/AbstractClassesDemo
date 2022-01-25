using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleUI
{
    public class Motorcycle : Vehicle
    {
        public bool HasSideCart { get; set; } = false;

        public override void DriveAbstract()
        {
           Console.WriteLine("Motorcycle is Driveable");
        }
        public override string DriveVirtual()
        {
            return "Overriding an virtual method";
        }
        


    }
}
