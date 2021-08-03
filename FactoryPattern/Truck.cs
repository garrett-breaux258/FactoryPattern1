using System;
namespace FactoryPattern
{
    public class Truck : IVehicle
    {
        public Truck()
        {
        }
        
        public void Drive()
        {
            Console.WriteLine("We will start building your truck");
        }
    }
}
