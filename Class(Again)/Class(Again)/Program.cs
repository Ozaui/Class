using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAgain
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car(4, "Red", "Renauld");
            
            car.runEngine();
            car.lockDoor();

            Console.WriteLine("Car model is " + car.model);
            Console.WriteLine("Car colour is " + car.colour);

            Console.ReadLine();
        }
    }
}
