using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoeeAmzaleg_HWS_Exceptions
{
    public interface IGarage
    {
        public void AddCar(Car car);
        public void TakeOutCar(Car car);
        public void FixCar(Car car);
    }
}
