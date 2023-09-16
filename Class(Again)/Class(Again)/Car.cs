using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace ClassAgain
{
    public class Car
    {
        public int numberofDoor;
        public string model;
        public string colour;

        public Car(int numberofDoor, string colour, string model)
        {
            this.numberofDoor = numberofDoor;
            this.colour = colour;
            this.model = model;
        }

        public void runEngine()
        {
            Console.WriteLine("The engine is running...");
        }
        public void lockDoor()
        {
            Console.WriteLine("The doors are locking...");
        }
    }
}
