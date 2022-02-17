using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoeeAmzaleg_HWS_Exceptions
{
    public class Car
    {
        public string Brand { get; set; }
        public bool TotalLost { get; set; }
        public bool NeedsRepair { get; set; }
        public Car(string Brand, bool TotalLost, bool NeedsRepair)
        {
            this.Brand = Brand;
            this.TotalLost = TotalLost;
            this.NeedsRepair = NeedsRepair;
            try
            {
                if (TotalLost == true && NeedsRepair == false)
                    throw new RepairMismatchException("this car dont need repair...");
            }
            catch (Exception)
            {
                throw;

            }
        }
    }
}
