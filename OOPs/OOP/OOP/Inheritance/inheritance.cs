using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Inheritance
{
    internal class inheritance
    {
        public class Vehicle
        {
            protected string Brand;
            protected int Speed;

            public Vehicle(string brand, int speed)
            {
                Brand = brand;
                Speed = speed;
            }
            public void DisplayVehicleInfo()
            {
                Console.WriteLine($"Vehicle Brand : {Brand}, SpeedVehicle : {Speed}");
            }
        }
        public class Car : Vehicle
        {
            public Car(string brand ,int speed) : base(brand, speed)
            {

            }


        }
        public static void Main(string[] args)
            {
            Car v1 = new Car("Toyota", 40);
            v1.DisplayVehicleInfo();
            }   

            
        
    }
       
}

