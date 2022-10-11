using System;
using System.Collections.Generic;

namespace Generics_Delegates_Exercise
{
    public class Checkout<Items> where Items : IVehicle
    {
        private Dictionary<Items, int> _vehicleOrders;

        public Checkout()
        {
            _vehicleOrders = new Dictionary<Items, int>();
        }

        public void AddToCheckout(Items vechile)
        {
            //Not the best way to check if obj is in dictionary (defeats the purpose of a dictionary if we have to loop to see if a key matches)
            //ideally we would have to implement a hashkey for the object
            foreach (var keyValue in _vehicleOrders)
            {
                if (keyValue.Key.Equals(vechile))
                {
                    _vehicleOrders[keyValue.Key] = keyValue.Value + 1;
                    return;
                }
            }
            _vehicleOrders.Add(vechile, 1);
        }

        public void PrintOrders()
        {
            Console.WriteLine($"{Environment.NewLine}Order consists of the following:");
            foreach (var kv in _vehicleOrders)
            {
                var carInstance = kv.Key;
                var info = $"Item Brand: {carInstance.Brand}{Environment.NewLine}";
                info += $"Item Year: {carInstance.Year:d}{Environment.NewLine}";
                info += $"Item Color: {carInstance.Color}";

                Console.WriteLine($"{info}");
                Console.WriteLine($"Quantity {kv.Value} {Environment.NewLine}");
            }
        }
    }
}
