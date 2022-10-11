
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics_Delegates_Exercise
{
    internal static class VechileHelperClass
    {
        public static void DisplayInventory<Vehicle>(Dictionary<int, Vehicle> allCarsInInventory, Checkout<Vehicle> checkOutInstance, Func<KeyValuePair<int, Vehicle>, Vehicle, string> func = null) where Vehicle : IVehicle
        {
            int quitValue = -1;

            if (func == null)
                func = DisplayVehicleInfo;

            while (true)
            {
                Console.WriteLine();
                Console.WriteLine($"This is the inventory: ");
                foreach (var carKV in allCarsInInventory)
                {
                    var carInstance = carKV.Value;
                    string info = func(carKV, carInstance);

                    Console.WriteLine($"{info}"); Console.WriteLine();
                }

                Console.WriteLine("Please select Id or enter -1 to go back to previous menu");

                var inputId = int.Parse(Console.ReadLine()); //Assume that selection will not require error handling 

                if (inputId == quitValue) break;

                checkOutInstance.AddToCheckout(allCarsInInventory[inputId]);
                Console.WriteLine("Item has been added to checkout!");
            }
        }

        private static string DisplayVehicleInfo<Vehicle>(KeyValuePair<int, Vehicle> carKV, Vehicle carInstance) where Vehicle : IVehicle
        {
            Console.WriteLine($"Inventory Id: {carKV.Key}");
            var info = $"Item Brand: {carInstance.Brand}{Environment.NewLine}";
            info += $"Item Year: {carInstance.Year:d}{Environment.NewLine}";
            info += $"Item Color: {carInstance.Color}";
            return info;
        }
    }
}

