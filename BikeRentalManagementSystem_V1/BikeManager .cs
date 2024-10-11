using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BikeRentalManagementSystem_V1
{
    public class BikeManager
    {
        List<Bike> bikes = new List<Bike>();
       public void CreateBike(Bike bike)
        {
            bikes.Add(bike);
            Console.WriteLine("bike added successfully");
        }


        public void ReadBikes()
        {
            Console.WriteLine("List of bike :");

            foreach (Bike bike in bikes)
            {
                Console.WriteLine(bike);
            }

        }


        public void UpdateBike(string bikeid, string brand, string model, decimal renatlprice)
        {
            var updateid = bikes.FirstOrDefault(b => b.BikeId == bikeid);
            if(updateid != null)
            {
                updateid.RentalPrice = renatlprice;
                updateid.Model = model;
                updateid.Brand = brand;
            }
            Console.WriteLine("bike update successfully");
        }


        public void DeleteBike(string bikeid)
        {
            var updateid = bikes.FirstOrDefault(b => b.BikeId == bikeid);
            bikes.Remove(updateid);
            Console.WriteLine("bike Remove successfully");
        }

        public decimal ValidateBikeRentalPrice(decimal price)
        {
            
            while (true) {
                if (price > 0)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Enter the positve number");
                }

            }
            return price;
        }
    }
}
