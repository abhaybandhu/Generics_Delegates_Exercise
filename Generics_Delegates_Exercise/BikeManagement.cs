using System.Collections.Generic;
using System;

namespace Generics_Delegates_Exercise
{
    internal class BikeManagement : VehicleManagement<MotorBike>
    {
       /* public void Execute(Func<KeyValuePair<int, MotorBike>, MotorBike, string> adminFunc)
        {
            const int MENU_OPT_INVENTORY_CAR = 1;
            const int MENU_OPT_VIEW_CHECKOUT = 2;

            var allBikesInInventory = InventoryRepo.InventoryBikes;
            var checkOutInstance = new Checkout<MotorBike>();
            Console.WriteLine();

            while (true)
            {
                Console.WriteLine($"Please Choose: {Environment.NewLine}");

                Console.WriteLine("1. See Bike inventory");
                Console.WriteLine($"2. See checkout basket");
                Console.WriteLine($"-1. Go back{Environment.NewLine}");

                var menuSelection = int.Parse(Console.ReadLine());

                if (menuSelection == MENU_OPT_INVENTORY_CAR)
                {
                    VechileHelperClass.DisplayInventory(allBikesInInventory, checkOutInstance, adminFunc);
                }
                else if (menuSelection == MENU_OPT_VIEW_CHECKOUT)
                {
                    checkOutInstance.PrintOrders();
                    Console.WriteLine();
                }
                else
                {
                    break;
                }
            }
        }*/
    }
}

