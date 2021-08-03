using System;
namespace FactoryPattern
{
    public class VehicleFactory 
    {

        public static IVehicle GetVehicle()
        {
            Console.WriteLine("How many wheels would you like on your vehicle?");
            var answer = Console.ReadLine().ToString();
            if (answer == "2")
            {
                return  new Motorcycle();
                var motorcycle = new Motorcycle();
                motorcycle.Drive();
               
            }
            else
            {
                Console.WriteLine("Would you prefer a trunk or bed?");
                var finalOption = Console.ReadLine();
                switch (finalOption.ToLower())
                {
                    case "trunk":
                        return new Car();
                        var car = new Car();
                        car.Drive();
                        break;
                    case "bed":
                        return new Truck();
                        var truck = new Truck();
                        truck.Drive();
                        break;
                    default:
                        return new Car();
                        var myCar = new Car();
                        myCar.Drive();
                        break;
                }


            }
        }
    }
}
