using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics_Delegates_Exercise
{
    public interface IVehicle
    {
        Brand Brand { get; set; }
        DateTime Year { get; set; }
        Color Color { get; set; }
    }
}
