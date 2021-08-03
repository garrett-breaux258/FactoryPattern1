using System;

namespace FactoryPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var newVehicle = VehicleFactory.GetVehicle();
            newVehicle.Drive();







        }
       
        

    }
}
