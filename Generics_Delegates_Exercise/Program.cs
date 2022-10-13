using System;
using System.Collections.Generic;

namespace Generics_Delegates_Exercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int CAR_SELECTION = 1;
            const int BIKE_SELECTION = 2;
            bool isAdmin = true;
            Func<KeyValuePair<int, MotorBike>, MotorBike, string> AdminFunc = null;
            if (isAdmin)
            {
                AdminFunc = DisplayVechileInfoAdmin;
            }
            while (true)
            {
                Console.WriteLine("Selection:");
                Console.WriteLine("1. View Cars");
                Console.WriteLine("2. View MotorBike");

                switch (int.Parse(Console.ReadLine())) //Assume no error handling is required
                {
                    case CAR_SELECTION:
                        var carManagement = new CarManagement();
                        carManagement.Execute();
                        break;

                    case BIKE_SELECTION:
                        var bikeManagement = new BikeManagement();

                        bikeManagement.Execute(AdminFunc);
                        

                        break;

                    default:
                        return;
                }
            }
        }
        private static string DisplayVechileInfoAdmin(KeyValuePair<int, MotorBike> carKV, MotorBike carInstance)
        {
            Console.WriteLine($"Inventory Id: {carKV.Key}");
            var info = $"Item Brand: {carInstance.Brand}{Environment.NewLine}";
            info += $"Item Year: {carInstance.Year:d}{Environment.NewLine}";
            info += $"Item Color: {carInstance.Color}{Environment.NewLine}";
            info += $"Item Stock: {carInstance.CountInStock}";
            return info;
        }
    }
}
