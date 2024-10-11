using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BikeRentalManagementSystem_V1
{
    public class Bike
    {
        public string BikeId { get; set; }

        public string Brand {  get; set; }
        public string Model {  get; set; }
        public decimal RentalPrice {  get; set; }

        public int TotalBikes = 0;


        public Bike(string bikeid ,string brand,string model , decimal renatlprice)
        {
            BikeId =bikeid; 
            Brand =brand; 
            Model =model; 
            RentalPrice = renatlprice;
            TotalBikes++;
        }

        public virtual string DisplayBikeInfo()
        {
            return $"bikeId : {BikeId}, brand: {Brand}, model: {Model}, rentalPrice: {RentalPrice}";
        }
    }

    public class ElectricBike : Bike
    {
       public string BatteryCapacity {  get; set; }
       public string MotorPower { get; set; }

        public ElectricBike(string bikeid, string brand, string model, decimal renatlprice, string batterycapacity, string motorpower) : base(bikeid, brand, model, renatlprice)
        {
            BatteryCapacity = batterycapacity;
            MotorPower = motorpower;

        }

        public override string DisplayBikeInfo()
        {
            return $"bikeId : {BikeId}, brand: {Brand}, model: {Model}, rentalPrice: {RentalPrice}";
        }
    }

    public class PetrolBike : Bike
    {
        public string FuelTankCapacity { get; set; }
        public string EngineCapacity { get; set; }

        public PetrolBike(string bikeid, string brand, string model, decimal renatlprice, string fueltankcapacity, string enginecapacity):base(bikeid, brand,  model, renatlprice)
        {
            FuelTankCapacity = fueltankcapacity;
            EngineCapacity = enginecapacity;

        }

        public override string DisplayBikeInfo()
        {
            return $"bikeId : {BikeId}, brand: {Brand}, model: {Model}, rentalPrice: {RentalPrice}";
        }
    }
}
