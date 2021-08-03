using System;
namespace FactoryPattern
{
    public class Motorcycle : IVehicle
    {
        public Motorcycle()
        {
        }
      
        public void Drive()
        {
            Console.WriteLine("We will start building your motorcycle");
        }
    }
}
