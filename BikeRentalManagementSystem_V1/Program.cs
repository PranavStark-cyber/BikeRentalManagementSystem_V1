using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BikeRentalManagementSystem_V1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BikeManager manager = new BikeManager();
            int option;

            //Bike bike = new Bike ("BIKE_001","YAMAHA" ," mt - 15" , 10.00 );

            do
            {
                Console.WriteLine("Bike Rental Management System:");
                Console.WriteLine("1. Add a Bike");
                Console.WriteLine("2. View All Bikes");
                Console.WriteLine("3. Update a Bike");
                Console.WriteLine("4. Delete a Bike");
                Console.WriteLine("5. Exit");
                Console.WriteLine("Choose an option:");
                option =int.Parse(Console.ReadLine());


                switch(option)
                {
                    case 1:
                        Console.WriteLine("Enter the id");
                        string bikeid = Console.ReadLine(); 
                        Console.WriteLine("Enter the brnad");
                        string bikebrand = Console.ReadLine();
                        Console.WriteLine("Enter the model");
                        string bikemodel = Console.ReadLine();
                        Console.WriteLine("Enter the Rentalprice");
                        decimal bikerentalprice =decimal.Parse( Console.ReadLine());

                        decimal rentalprice =manager.ValidateBikeRentalPrice(bikerentalprice);


                        

                        Bike newbike = new Bike(bikeid, bikebrand,bikemodel, rentalprice);
                        manager.CreateBike(newbike);
                        break;

                        case 2:

                        manager.ReadBikes();
                        break;

                        case 3:
                        Console.WriteLine("Enter the id for the update bike");
                        string newbikeid = Console.ReadLine();
                        Console.WriteLine("Enter the newbrnad");
                        string newbikebrand = Console.ReadLine();
                        Console.WriteLine("Enter the newmodel");
                        string newbikemodel = Console.ReadLine();
                        Console.WriteLine("Enter the newRentalprice");
                        decimal newbikerentalprice = decimal.Parse(Console.ReadLine());

                        manager.UpdateBike(newbikeid,newbikebrand,newbikemodel,newbikerentalprice);
                        break;

                        case 4:
                        var deleteid = Console.ReadLine();
                        manager.DeleteBike(deleteid);
                        break;

                        case 5:
                        Console.WriteLine("thank you and successfully exit");
                        break;

                        default:
                        break;
                }


            } while (option!=5);

        }
    }
}
