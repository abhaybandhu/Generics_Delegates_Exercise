
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Generics_Delegates_Exercise
{
    internal class VehicleManagement<Vehicle> where Vehicle : IVehicle
    {

        Dictionary<int, Vehicle> allCarsInInventory;
        Checkout<Vehicle> checkOutInstance = new Checkout<Vehicle>();

        public VehicleManagement( )
        {
            this.checkOutInstance = new Checkout<Vehicle>();

            //this.allCarsInInventory = InventoryRepo.Inventories[typeof(Vehicle)];
        
            var repo = InventoryRepo.Inventories[typeof(Vehicle)];
            allCarsInInventory = repo.ToDictionary(key => key.Key, element => (Vehicle)element.Value);
            
        }

        public void Execute(Func<KeyValuePair<int, Vehicle>, Vehicle, string> adminFunc = null)
        {
            const int MENU_OPT_INVENTORY_CAR = 1;
            const int MENU_OPT_VIEW_CHECKOUT = 2;
            string MENU_OPT_VEHICLE = typeof(Vehicle).ToString().Split('.')[1];

            
            Console.WriteLine();

            while (true)
            {
                Console.WriteLine($"Please Choose: {Environment.NewLine}");

                Console.WriteLine($"1. See {MENU_OPT_VEHICLE} inventory");
                Console.WriteLine($"2. See checkout basket");
                Console.WriteLine($"-1. Go back{Environment.NewLine}");

                var menuSelection = int.Parse(Console.ReadLine());

                if (menuSelection == MENU_OPT_INVENTORY_CAR)
                {
                    VechileHelperClass.DisplayInventory(allCarsInInventory, checkOutInstance, adminFunc);
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
        }
    }
}
