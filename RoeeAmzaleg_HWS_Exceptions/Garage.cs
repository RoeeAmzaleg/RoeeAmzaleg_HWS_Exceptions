using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoeeAmzaleg_HWS_Exceptions
{
    public class Garage : IGarage
    {
        public Car[] Cars = new Car[0];
        public string[] CarTypes;
        public Garage(string[] CarTypes)
        {
            this.CarTypes = CarTypes;
        }
        public void AddCar(Car car)
        {
            try
            {
                for (int i = 0; i <Cars.Length; i++)
                {
                    if (Cars[i].Brand == car.Brand)
                    {
                        throw new CarAlreadyHereException("sorry car is already registerd...");
                    }
                    if (car.TotalLost == true)
                    {
                        throw new WeDoNotFixTotalLostException("sorry we do not fix total lost cars...");
                    }
                    if (car.Brand != Cars[i].Brand)
                    {
                        throw new WrongGarageException("sorry we do not fix this type of car..");
                    }
                    if (car == null)
                    {
                        throw new CarNullException("sorry no car in exist...");
                    }
                    if (car.NeedsRepair == false)
                    {
                        throw new RepairMismatchException("sorry your car dont needed repair...");
                    }

                    else
                    {
                        i++;
                    }
                }
            }
            catch (CarAlreadyHereException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (WeDoNotFixTotalLostException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (WrongGarageException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (CarNullException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (RepairMismatchException ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
        public void TakeOutCar(Car car)
        {
            try
            {
                for (int i = 0; i <Cars.Length; i++)
                {
                    if (car == null)
                    {
                        throw new CarNullException("sorry car is not exist...");
                    }
                    if (car.Brand != Cars[i].Brand)
                    {
                        throw new CarNotInGarageException("sorry car is not registerd...");
                    }
                    if (car.NeedsRepair == true)
                    {
                        throw new CarNotReadyException("sorry your car is still needed repair...");
                    }
                    else
                    {
                        i--;
                    }
                }
            }
            catch (CarNullException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (CarNotInGarageException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (CarNotReadyException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        public void FixCar(Car car)
        {
            try
            {
                for (int i = 0; i <Cars.Length; i++)
                {
                    if (car == null)
                    {
                        throw new CarNullException("sorry car is not exist...");
                    }
                    if (car != Cars[i])
                    {
                        throw new CarNotInGarageException("sorry car is not registerd...");
                    }
                    if (car.NeedsRepair == false)
                    {
                        throw new RepairMismatchException("sorry your car dont needed repair...");
                    }
                    else
                    {
                        car.NeedsRepair = false;
                    }
                }
            }
            catch (CarNullException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (CarNotInGarageException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (CarNotReadyException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
